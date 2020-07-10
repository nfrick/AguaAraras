﻿using DataLayer;
using DbContextExtensions;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmPessoas : Form {
        private readonly AguaArarasEntities _ctx = new AguaArarasEntities();

        private readonly SaveTools savetools;

        public frmPessoas() {
            InitializeComponent();
            savetools = new SaveTools(_ctx, Text);
            _ctx.Pessoas.Load();
            bsPessoas.DataSource = _ctx.Pessoas.Local.ToBindingList();

            Tuple<byte, string>[] cobrancaTipos = {
                Tuple.Create((byte) 0, "Nenhuma"),
                Tuple.Create((byte) 1, "Impressa"), Tuple.Create((byte) 2, "E-Mail")
            };
            cobrancaComboBox.ValueMember = "Item1";
            cobrancaComboBox.DisplayMember = "Item2";
            cobrancaComboBox.DataSource = new BindingSource(cobrancaTipos, null);

            Tuple<byte, string>[] telefoneTipos = {
                Tuple.Create((byte) 1, "Residência"),
                Tuple.Create((byte) 2, "Araras"),
                Tuple.Create((byte) 3, "Trabalho"),
                Tuple.Create((byte) 4, "Celular")
            };
            var col = (DataGridViewComboBoxColumn)dgvTelefones.Columns["colTipo"];
            col.ValueMember = "Item1";
            col.DisplayMember = "Item2";
            col.DataSource = new BindingSource(telefoneTipos, null);
        }

        #region FORM --------------------------
        private void frmPessoas_Load(object sender, EventArgs e) {
            dgvPessoas.Sort(dgvPessoas.Columns[1], ListSortDirection.Ascending);
        }

        private void frmPessoas_FormClosing(object sender, FormClosingEventArgs e) {
            savetools.FormClosing(sender, e);
        }
        #endregion -----------------------------

        #region TOOLSTRIP ---------------------

        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            if (savetools.SalvarAlteracoes()) {
                EnableButtons();
            }
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e) {
            _ctx.RevertChanges();
            EnableButtons();
        }

        private void EnableButtons() {
            var enable = _ctx.ChangeTracker.HasChanges();
            toolStripButtonSave.Enabled = enable;
            toolStripButtonUndo.Enabled = enable;
        }

        #endregion ----------------------------

        #region DATAGRIDVIEW ------------------
        private void dgvPessoas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var p = (Pessoa)dgvPessoas.Rows[e.RowIndex].DataBoundItem;
            e.CellStyle.ForeColor = p.Ativo ? e.CellStyle.ForeColor : Color.Crimson;
        }

        private void dgvPessoas_SelectionChanged(object sender, EventArgs e) {
            EnableButtons();
            dgvPagamentos.Sort(dgvPagamentos.Columns[0], ListSortDirection.Descending);
        }

        private void dgvEnderecos_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if (e.ColumnIndex > 4) {
                return;
            }

            var txt = e.FormattedValue.ToString();
            if (string.IsNullOrEmpty(txt)) {
                e.Cancel = true;
                dgvEnderecos.Rows[e.RowIndex].ErrorText =
                    $"{dgvEnderecos.Columns[e.ColumnIndex].HeaderText} não pode ficar em branco.";
                return;
            }
            switch (e.ColumnIndex) {
                case 3: // Estado
                    dgvEnderecos.CurrentRow.Cells[3].Value = txt;
                    const string pattern = @"[a-zA-Z][a-zA-Z]";
                    if (Regex.IsMatch(txt.ToUpper(), pattern)) {
                        return;
                    }
                    e.Cancel = true;
                    dgvEnderecos.Rows[e.RowIndex].ErrorText = "Estado inválido.";
                    break;
                case 4: // CEP
                    const string pattern1 = @"[0-9][0-9].[0-9][0-9][0-9]-[0-9][0-9][0-9]";
                    const string pattern2 = @"[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]";
                    if (Regex.IsMatch(txt, pattern1) || Regex.IsMatch(txt, pattern2)) {
                        return;
                    }
                    e.Cancel = true;
                    dgvEnderecos.Rows[e.RowIndex].ErrorText = "CEP inválido.";
                    break;
            }
        }

        private void dgvEnderecos_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex > 4) {
                return;
            }
            var cell = dgvEnderecos.CurrentRow.Cells[e.ColumnIndex];
            var txt = cell.Value.ToString().Trim();
            cell.Value = e.ColumnIndex == 3 ? txt.ToUpper() : txt;
        }

        private void dgvTelefones_CellValidating(object sender, DataGridViewCellValidatingEventArgs e) {
            if (e.ColumnIndex != 1) {
                return;
            }

            var txt = e.FormattedValue.ToString();
            if (!string.IsNullOrWhiteSpace(txt)) {
                return;
            }
            e.Cancel = true;
            dgvTelefones.Rows[e.RowIndex].ErrorText = "Telefone não pode ficar em branco.";
        }

        private void dgvTelefones_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex > 1) {
                return;
            }
            var cell = dgvTelefones.CurrentRow.Cells[e.ColumnIndex];
            cell.Value = cell.Value.ToString().Trim();
        }

        private void dgvTelefones_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            // Necessário para erro de Tipo = null em novo telefone.
        }
        #endregion-----------------------------

        #region VALIDATION---------------------

        private void textBoxEMail_Validating(object sender, CancelEventArgs e) {
            var arr = textBoxEMail.Text.Replace(Environment.NewLine, "#").Split('#')
                .Where(i => !string.IsNullOrEmpty(i)).Distinct();
            var bad = arr.Where(i => !IsValidEmail(i));
            e.Cancel = bad.Count() != 0;
            if (e.Cancel) {
                errorProvider1.SetError(textBoxEMail, "E-mail inválido!\n\t" + string.Join("\n\t", bad));
            }
            else {
                errorProvider1.Clear();
            }
            textBoxEMail.Text = string.Join(Environment.NewLine, arr);
        }

        private static bool IsValidEmail(string email) {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }

        #endregion ---------------------------

    }
}
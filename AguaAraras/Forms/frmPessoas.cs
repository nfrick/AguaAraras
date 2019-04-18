using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmPessoas : Form {
        public List<Pessoa> Pessoas;

        private BindingSource _sourceEnderecos;
        public List<Endereco> EnderecosAll;
        public List<Endereco> Enderecos;
        public List<Endereco> EnderecosDeleted = new List<Endereco>();

        private BindingSource _sourceTelefones;
        public List<Telefone> TelefonesAll;
        public List<Telefone> Telefones;
        public List<Telefone> TelefonesDeleted = new List<Telefone>();

        private bool _loading = true;
        public frmPessoas() {
            InitializeComponent();
            bindingSourceEnderecos.ListChanged +=
                new ListChangedEventHandler(BindingSource_ListChanged);
            bindingSourceTelefones.ListChanged +=
                new ListChangedEventHandler(BindingSource_ListChanged);
        }

        #region FORM ------------------------------------------
        private void frmPessoas_Load(object sender, EventArgs e) {
            Pessoas = Database.PessoasGet();
            foreach (var p in Pessoas) {
                listBoxPessoas.Items.Add(p.Nome);
            }

            bindingSourcePessoas.DataSource = new BindingSource { DataSource = Pessoas };

            EnderecosAll = Database.EnderecosGet();
            _sourceEnderecos = new BindingSource { DataSource = Enderecos };
            bindingSourceEnderecos.DataSource = _sourceEnderecos;

            TelefonesAll = Database.TelefonesGet();
            _sourceTelefones = new BindingSource { DataSource = TelefonesAll };
            bindingSourceTelefones.DataSource = _sourceTelefones;

            Tuple<byte, string>[] cobrancaTipos = { Tuple.Create((byte)0, "Nenhuma"),
                Tuple.Create((byte)1, "Impressa"), Tuple.Create((byte)2, "E-Mail") };
            cobrancaComboBox.ValueMember = "Item1";
            cobrancaComboBox.DisplayMember = "Item2";
            cobrancaComboBox.DataSource = new BindingSource(cobrancaTipos, null);

            Tuple<byte, string>[] telefoneTipos =
                { Tuple.Create((byte)1, "Residência"), Tuple.Create((byte)2, "Araras"), Tuple.Create((byte)3, "Trabalho"), Tuple.Create((byte)4, "Celular")};

            var theColumn = (DataGridViewComboBoxColumn)this.dgvTelefones.Columns["dataGridViewTextBoxColumnTipo"];
            theColumn.ValueMember = "Item1";
            theColumn.DisplayMember = "Item2";
            theColumn.DataSource = new BindingSource(telefoneTipos, null);

            _loading = false;
            SetChildren();
            listBoxPessoas.SelectedIndex = bindingSourcePessoas.Position;
        }

        private void frmPessoas_FormClosing(object sender, FormClosingEventArgs e) {
            if (!Pessoas.Any(p => p.Updated) && !EnderecosAll.Any(end => end.Updated) &&
                !TelefonesAll.Any(t => t.Updated)) {
                return;
            }
            switch (MessageBox.Show("Existem alterações pendentes. Deseja salvar?", "Pessoas",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) {
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    SaveAll();
                    break;
                case DialogResult.No:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion --------------------------------------------

        #region BINDING SOURCE ------------------------------------------
        private void BindingSource_ListChanged(object sender, ListChangedEventArgs e) {
            toolStripButtonSave.Enabled |= e.ListChangedType == ListChangedType.ItemChanged;
        }

        private void bindingSourcePessoas_CurrentChanged(object sender, EventArgs e) {
            if (!_loading) {
                SetChildren();
            }
        }

        #endregion ------------------------------------------------------

        #region NAVIGATION ---------------------------------------
        private void listBoxPessoas_SelectedIndexChanged(object sender, EventArgs e) {
            var updated = ((Pessoa)bindingSourcePessoas.Current).Updated ||
                          Enderecos.Any(end => end.Updated) || Telefones.Any(t => t.Updated);
            if (updated && MessageBox.Show("Existem alterações pendentes. Salvar?", "Pessoas",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes) {
                SaveCurrent();
            }
            bindingSourcePessoas.Position = listBoxPessoas.SelectedIndex;
            var pessoa = (Pessoa)bindingSourcePessoas.Current;
            toolStripButtonSave.Enabled = pessoa.Updated ||
                                          Enderecos.Any(end => end.Updated) || Telefones.Any(tel => tel.Updated);
        }

        private void bindingNavigatorMove_Click(object sender, EventArgs e) {
            if (!_loading) {
                listBoxPessoas.SelectedIndex = bindingSourcePessoas.Position;
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            SaveCurrent();
        }

        private void SaveCurrent() {
            foreach (var bindingSource in this.components.Components.OfType<BindingSource>()) {
                bindingSource.EndEdit();
            }

            var pessoas = new List<Pessoa> { (Pessoa)bindingSourcePessoas.Current };
            var endUpdated = Enderecos.Where(end => end.Updated);
            var telUpdated = Telefones.Where(tel => tel.Updated);
            if (Database.PessoaUpdate(pessoas, endUpdated, EnderecosDeleted, telUpdated, TelefonesDeleted)) {
                foreach (var p in pessoas) {
                    p.Updated = false;
                }

                foreach (var end in endUpdated) {
                    end.Updated = false;
                    if (EnderecosAll.All(endAll => endAll.ID != end.ID)) {
                        EnderecosAll.Add(end);
                    }
                }
                EnderecosDeleted.Clear();

                foreach (var tel in telUpdated) {
                    tel.Updated = false;
                    if (TelefonesAll.All(telAll => telAll.ID != tel.ID)) {
                        TelefonesAll.Add(tel);
                    }
                }
                TelefonesDeleted.Clear();
            }

            listBoxPessoas.Items[listBoxPessoas.SelectedIndex] = pessoas[0].Nome;
            _sourceEnderecos.ResetBindings(false);
            _sourceTelefones.ResetBindings(false);
        }

        private void SaveAll() {
            foreach (var bindingSource in this.components.Components.OfType<BindingSource>()) {
                bindingSource.EndEdit();
            }

            var pessoas = Pessoas.Where(p => p.Updated);
            var endUpdated = EnderecosAll.Where(end => end.Updated);
            var telUpdated = TelefonesAll.Where(tel => tel.Updated);
            Database.PessoaUpdate(pessoas, endUpdated, EnderecosDeleted, telUpdated, TelefonesDeleted);
        }

        private void SetChildren() {
            var pessoaID = ((Pessoa)bindingSourcePessoas.Current).ID;

            Enderecos?.Clear();
            Enderecos = EnderecosAll.Where(end => end.PessoaID == pessoaID).ToList();
            _sourceEnderecos.DataSource = Enderecos;
            dgvEnderecos.Columns[0].Visible = false;

            Telefones?.Clear();
            Telefones = TelefonesAll.Where(tel => tel.PessoaID == pessoaID).ToList();
            _sourceTelefones.DataSource = Telefones;
            dgvTelefones.Columns[0].Visible = false;
        }
        #endregion -----------------------------------------------

        #region ENDEREÇOS
        private void dataGridViewEnderecos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!Enderecos.Any() || Enderecos.Count <= e.RowIndex) {
                return;
            }
            if (Enderecos[e.RowIndex].IsNew) {
                e.CellStyle.BackColor = Color.Khaki;
            }
            else if (Enderecos[e.RowIndex].Updated) {
                e.CellStyle.BackColor = Color.Bisque;
            }
        }

        private void dataGridViewEnderecos_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }
            Enderecos[e.RowIndex].PessoaID = ((Pessoa)bindingSourcePessoas.Current).ID;
            Enderecos[e.RowIndex].Updated = true;
            _sourceEnderecos.ResetBindings(false);
        }

        private void dataGridViewEnderecos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            var row = e.Row.Index;
            if (!Enderecos[row].IsNew) {
                EnderecosDeleted.Add(Enderecos[row]);
            }
        }

        private void dataGridViewEnderecos_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            _sourceEnderecos.ResetBindings(false);
        }

        private void dataGridViewEnderecos_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show($@"Endereço: Data error in row {e.RowIndex} column {e.ColumnIndex}");
        }
        #endregion

        #region TELEFONES
        private void dataGridViewTelefones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!Telefones.Any() || Telefones.Count <= e.RowIndex) {
                return;
            }

            if (Telefones[e.RowIndex].IsNew) {
                e.CellStyle.BackColor = Color.Khaki;
            }
            else if (Telefones[e.RowIndex].Updated) {
                e.CellStyle.BackColor = Color.Bisque;
            }
        }

        private void dataGridViewTelefones_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }

            Telefones[e.RowIndex].PessoaID = ((Pessoa)bindingSourcePessoas.Current).ID;
            Telefones[e.RowIndex].Updated = true;
            _sourceTelefones.ResetBindings(false);
        }

        private void dataGridViewTelefones_UserDeletedRow(object sender, DataGridViewRowEventArgs e) {
            _sourceTelefones.ResetBindings(false);
        }

        private void dataGridViewTelefones_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            var row = e.Row.Index;
            if (!Telefones[row].IsNew) {
                TelefonesDeleted.Add(Telefones[row]);
            }
        }

        private void dataGridViewTelefones_DataError(object sender, DataGridViewDataErrorEventArgs e) {
            MessageBox.Show($@"Telefone: Data error in row {e.RowIndex} column {e.ColumnIndex}");
        }
        #endregion

        #region VALIDATION --------------------------------------
        private void eMailTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e) {
            var arr = eMailTextBox.Text.Replace(Environment.NewLine, "#").Split('#')
                .Where(i => !string.IsNullOrEmpty(i));
            e.Cancel = arr.Any(i => !IsValidEmail(i));
            if (e.Cancel) {
                errorProvider1.SetError(eMailTextBox, "E-mail inválido!");
            }
            else {
                errorProvider1.Clear();
            }
            eMailTextBox.Text = string.Join(Environment.NewLine, arr);
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

        private void pessoa_TextChanged(object sender, EventArgs e) {
            if (!((TextBox)sender).Modified) {
                return;
            } ((Pessoa)bindingSourcePessoas.Current).Updated = true;
            toolStripButtonSave.Enabled = true;
        }
        #endregion ----------------------------------------------
    }
}
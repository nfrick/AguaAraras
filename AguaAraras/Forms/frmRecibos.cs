﻿using AguaAraras.Classes;
using DataLayer;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DbContextExtensions;

namespace AguaAraras {
    public partial class frmRecibos : Form {

        private readonly AguaArarasEntities _ctx = new AguaArarasEntities();

        private Recibo ReciboAtual => (Recibo)bsRecibos.Current;
        //(Recibo)dgvRecibos.CurrentRow?.DataBoundItem;

        public frmRecibos() {
            InitializeComponent();
            _ctx.Recibos.Load();
            bsRecibos.DataSource = _ctx.Recibos.Local.ToBindingList();
        }

        private void frmRecibos_Load(object sender, EventArgs e) {
            dgvRecibos.Sort(dgvRecibos.Columns[0], ListSortDirection.Descending);
        }

        private void buttonRecalc_Click(object sender, EventArgs e) {
            ReciboAtual.RecalcCotas();
            dgvCotas.Refresh();
        }

        #region TOOLSRIP ----------------------------------------------------------
        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            //entityDataSourceRecibos.SaveChanges();
            _ctx.SaveChanges();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e) {
            //entityDataSourceRecibos.CancelChanges();
            _ctx.RevertChanges();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e) {
            var last = _ctx.Recibos.OrderByDescending(r => r.Vencimento.Year).ThenByDescending(r => r.Numero).First();
            var ativos = _ctx.Pessoas.Where(p => p.Ativo);
            var novo = new Recibo(last, ativos);
            _ctx.Recibos.Local.Add(novo);
            //_ctx.SaveChanges();
        }

        private void toolStripButtonCobrancasImpressas_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport("rptCobranca", "Cobranças", "DataSetReciboItens",
                ReciboAtual.Cotas.Where(i => i.Cobranca == 1));
            frm.Show();
        }

        private void toolStripButtonCobrancasEMail_Click(object sender, EventArgs e) {
            var frm = new frmCobrancaEmail(this.ParentForm, ReciboAtual);
            frm.Show();
        }

        private void toolStripButtonCobrancasSelecionadas_Click(object sender, EventArgs e) {
            if (dgvCotas.SelectedRows.Count == 0) {
                MessageBox.Show(@"Nenhum nome foi selecionado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var selecionados = (from DataGridViewRow n in dgvCotas.SelectedRows
                                select (Cota)n.DataBoundItem).OrderBy(c => c.Pessoa.Nome);
            frm.SetReport("rptCobranca", "DataSetReciboItens", "Cobranças", selecionados);
            frm.Show();
        }

        private void toolStripButtonRecibos_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport("rptRecibo", "Recibos", "DataSetReciboItens", ReciboAtual.Cotas.Where(c => c.GerarRecibo));
            frm.Show();
        }

        private void toolStripButtonFichaConferência_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport("rptFichaConferencia", "Ficha Conferência", "DataSetReciboItens",
                ReciboAtual.Cotas.Where(c => c.GerarRecibo));
            frm.Show();
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e) {
            var counter = 0;
            using (var ctx = new MoneyBinEntities()) {
                var itens = ctx.BalanceItemsAgua(ReciboAtual.ID).ToList();
                if (!itens.Any()) {
                    return;
                }

                foreach (DataGridViewRow row in dgvCotas.Rows) {
                    if (row.Cells[2].Value != null) {
                        continue;
                    }

                    var item = itens.FirstOrDefault(i => i.Centavos == (int)row.Cells[0].Value ||
                                                         i.Nome == (string)row.Cells[1].Value);
                    if (item == null) {
                        continue;
                    }

                    row.Cells[2].Value = item.Data;
                    counter++;
                }
            }
            MessageBox.Show($@"{counter} atualizações.", @"Pagamentos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonColect_Click(object sender, EventArgs e) {
            var data = DateTime.Today;
            if (clsPromptDialog.InputDate("Pagamento de Distribuição e coleta", "Data", ref data) != DialogResult.OK) {
                return;
            }

            ReciboAtual.Movimentos.Add(new Movimento() {
                Tipo = "Cobrança",
                Data = data,
                ReciboID = ReciboAtual.ID,
                Historico = $"distribuição/coleta de cotas {ReciboAtual.DescricaoShort}",
                Valor = (ReciboAtual.Cota * ReciboAtual.Meses * -2) / 3
            });
            _ctx.SaveChanges();
            MessageBox.Show("Movimento criado.", "Recibos", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        #endregion ----------------------------------------------------------------

        #region DATAGRIDVIEW ------------------------------------------------------
        private void dgvRecibos_SelectionChanged(object sender, EventArgs e) {
            if (dgvCotas.RowCount == 0) {
                return;
            }

            dgvCotas.Sort(dgvCotas.Columns[1], ListSortDirection.Ascending);
        }

        private void dgvCotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var cota = (Cota)dgvCotas.Rows[e.RowIndex].DataBoundItem;
            if (cota.Cobranca == 2) {
                e.CellStyle.ForeColor = Color.DarkGreen;
            }
        }

        private void dgvCotas_SelectionChanged(object sender, EventArgs e) {
            selecionadasToolStripMenuItem.Enabled = dgvCotas.SelectedRows.Count > 0;
        }

        private void dgvCotas_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex < 2 || e.ColumnIndex > 3) {
                return;
            }
            bsRecibos.ResetBindings(false);
        }
        #endregion ----------------------------------------------------------------

        private void bsRecibos_CurrentChanged(object sender, EventArgs e) {
            toolStripButtonColect.Enabled = !ReciboAtual.Movimentos.Any();
        }
    }
}
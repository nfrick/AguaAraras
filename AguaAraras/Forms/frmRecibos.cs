using AguaAraras.Classes;
using DataLayer;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmRecibos : Form {

        private DataLayer.Recibo ReciboAtual =>
            (DataLayer.Recibo) dgvRecibos.CurrentRow?.DataBoundItem;

        public frmRecibos() {
            InitializeComponent();
        }

        private void frmRecibos_Load(object sender, EventArgs e) {
            dgvRecibos.Columns[0].Visible = false;
            dgvRecibos.Sort(dgvRecibos.Columns[1], ListSortDirection.Descending);
        }

        private void buttonRecalc_Click(object sender, EventArgs e) {
            foreach (var cota in ReciboAtual.Cotas) {
                cota.Valor = Math.Round(ReciboAtual.Meses * ReciboAtual
                                            .Cota * cota.Pessoa.Tomadas, 0);
            }
            dgvCotas.Refresh();
        }

        #region TOOLSRIP ----------------------------------------------------------
        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            entityDataSourceRecibos.SaveChanges();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e) {
            entityDataSourceRecibos.CancelChanges();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e) {
            using (var ctx = new AguaArarasEntities()) {
                var last = ctx.Recibos.OrderByDescending(r => r.Vencimento.Year).ThenByDescending(r => r.Numero).First();
                var ativos = ctx.Pessoas.Where(p => p.Ativo);
                var novo = new Recibo(last, ativos);
                ctx.Recibos.Add(novo);
                ctx.SaveChanges();
                entityDataSourceRecibos.Refresh();
            }
        }
        
        private void toolStripButtonCobrancasImpressas_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport(ReciboAtual.Cotas.Where(i => i.Cobranca == 1).ToList(), "rptCobranca", "DataSetReciboItens", "Cobranças");
        }

        private void toolStripButtonCobrancasEMail_Click(object sender, EventArgs e) {
            var frm = new frmCobrancaEmail(this.ParentForm, ReciboAtual.ID);
            frm.Show();
        }

        private void toolStripButtonCobrancasSelecionadas_Click(object sender, EventArgs e) {
            if (dgvCotas.SelectedRows.Count == 0) {
                MessageBox.Show(@"Nenhum nome foi selecionado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var selecionados = (from DataGridViewRow n in dgvCotas.SelectedRows
                select (DataLayer.Cota)n.DataBoundItem).OrderBy(c => c.Pessoa.Nome).ToList();
            frm.SetReport(selecionados, "rptCobranca", "DataSetReciboItens", "Cobranças");
        }

        private void toolStripButtonRecibos_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport(ReciboAtual.Cotas.Where(c => c.GerarRecibo).ToList(),
                "rptRecibo", "DataSetReciboItens", "Recibos");
        }

        private void toolStripButtonFichaConferência_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport(ReciboAtual.Cotas.Where(c => c.GerarRecibo).ToList(),
                "rptFichaConferencia", "DataSetReciboItens", "Ficha Conferência");
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e) {
            var counter = 0;
            using (var ctx = new MoneyBinEntities()) {
                var itens = ctx.BalanceItemsAgua(ReciboAtual.ID).ToList();
                if (!itens.Any()) return;
                foreach (DataGridViewRow row in dgvCotas.Rows) {
                    if (row.Cells[2].Value != null) continue;
                    var item = itens.FirstOrDefault(i => i.Centavos == (int)row.Cells[0].Value ||
                                                         i.Nome == (string)row.Cells[1].Value);
                    if (item == null) continue;
                    row.Cells[2].Value = item.Data;
                    counter++;
                }
            }
            MessageBox.Show($@"{counter} atualizações.", @"Pagamentos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonColect_Click(object sender, EventArgs e) {
            using (var ctx = new AguaArarasEntities()) {
                if (ctx.Movimentos.Any(m => m.ReciboID == ReciboAtual.ID && m.Tipo == "carlos")) {
                    MessageBox.Show("Movimento já foi criado.", "Recibos", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                var data = DateTime.Now;
                if (clsPromptDialog.InputDate("Pagamento de Distribuição e coleta", "Data", ref data) != DialogResult.OK) return;

                ctx.Movimentos.Add(new DataLayer.Movimento() {
                    Tipo = "carlos",
                    Data = data,
                    ReciboID = ReciboAtual.ID,
                    Historico = ReciboAtual.DescricaoShort,
                    Valor = (ReciboAtual.Cota * ReciboAtual.Meses * -2) / 3
                });
                ctx.SaveChanges();
                MessageBox.Show("Movimento criado.", "Recibos", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        #endregion ----------------------------------------------------------------

        #region DATAGRIDVIEW ------------------------------------------------------
        private void dgvCotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if ((byte)dgvCotas.Rows[e.RowIndex].Cells[5].Value == 2) {
                e.CellStyle.ForeColor = Color.DarkGreen;
            }
        }

        private void dgvRecibos_SelectionChanged(object sender, EventArgs e) {
            if (dgvCotas.RowCount == 0) return;
            dgvCotas.Sort(dgvCotas.Columns[1], ListSortDirection.Ascending);
        }

        private void dgvCotas_SelectionChanged(object sender, EventArgs e) {
            selecionadasToolStripMenuItem.Enabled = dgvCotas.SelectedRows.Count > 0;
        }
        #endregion ----------------------------------------------------------------
    }
}
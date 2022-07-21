using DataLayer;
using DbContextExtensions;
using SuperPrompt;
using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmRecibos : Form {

        private readonly AguaArarasEntities _ctx = new AguaArarasEntities();

        private readonly SaveTools _savetools;

        private Recibo ReciboAtual => (Recibo)bsRecibos.Current;

        public frmRecibos() {
            InitializeComponent();
            _savetools = new SaveTools(_ctx, Text);
            _ctx.Recibos.Load();
            bsRecibos.DataSource = _ctx.Recibos.Local.ToBindingList();
        }

        private void frmRecibos_Load(object sender, EventArgs e) {
            dgvCotas.FormatColumnByHeader("ID", dgvCotas.StyleInteger, 40);
            dgvCotas.FormatColumnByHeader("Data", dgvCotas.StyleDateShort, 80);
            dgvCotas.FormatColumnByHeader("Valor", dgvCotas.StyleCurrency, 60);
            dgvRecibos.Sort(dgvRecibos.Columns[0], ListSortDirection.Descending);
            //dgvCotas.Sort(dgvCotas.Columns[1], ListSortDirection.Ascending);
            toolTip1.SetToolTip(buttonRecalc, "Recalcular cotas");
        }

        private void frmRecibos_FormClosing(object sender, FormClosingEventArgs e) {
            _savetools.FormClosing(sender, e);
        }

        private void buttonRecalc_Click(object sender, EventArgs e) {
            ReciboAtual.RecalcCotas();
            dgvCotas.Refresh();
        }

        private void bsRecibos_CurrentChanged(object sender, EventArgs e) {
            toolStripButtonColect.Enabled = !ReciboAtual.Movimentos.Any();
            if (dgvCotas.RowCount != 0) {
                dgvCotas.Sort(dgvCotas.Columns[1], ListSortDirection.Ascending);
            }
        }

        #region TOOLSRIP ----------------------------------------------------------
        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            _savetools.SalvarAlteracoes();
        }

        private void toolStripButtonUndo_Click(object sender, EventArgs e) {
            _ctx.RevertChanges();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e) {
            var last = _ctx.Recibos.OrderByDescending(r => r.Vencimento.Year).ThenByDescending(r => r.Numero).First();
            var ativos = _ctx.Pessoas.Where(p => p.Ativo);
            var novo = new Recibo(last, ativos);
            _ctx.Recibos.Local.Add(novo);
        }

        private void toolStripButtonCobrancasImpressas_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetLocalReport("rptCobranca", "Cobranças", "DataSetReciboItens",
                ReciboAtual.Cotas.Where(i => i.Cobranca == 1));
            frm.Show();
        }

        private void toolStripButtonCobrancasEMail_Click(object sender, EventArgs e) {
            var frm = new frmCobrancaEmail(this.ParentForm, ReciboAtual);
            frm.Show();
        }

        private void toolStripButtonCobrancasSelecionadas_Click(object sender, EventArgs e) {
            EmitirSelecionados("rptCobranca", "Cobranças");
        }

        private void EmitirSelecionados(string rptName, string dspName) {
            if (dgvCotas.SelectedRows.Count == 0) {
                MessageBox.Show(@"Nenhum nome foi selecionado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var selecionados = (from DataGridViewRow n in dgvCotas.SelectedRows
                                select (Cota)n.DataBoundItem).OrderBy(c => c.Pessoa.Nome);
            frm.SetLocalReport(rptName, dspName, "DataSetReciboItens", selecionados);
            frm.Show();
        }

        private void toolStripButtonRecibos_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetLocalReport("rptRecibo", "Recibos", "DataSetReciboItens",
                ReciboAtual.Cotas.Where(c => c.GerarRecibo));
            frm.Show();
        }

        private void toolStripButtonRecibosSelecionados_Click(object sender, EventArgs e) {
            EmitirSelecionados("rptRecibo", "Recibos");
        }

        private void toolStripButtonFichaConferência_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetLocalReport("rptFichaConferencia", "Ficha Conferência", "DataSetReciboItens",
                ReciboAtual.Cotas.Where(c => c.GerarRecibo));
            frm.Show();
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e) {
            var counter = 0;

            using (var ctx = new MoneyBinEntities()) {
                var balanco = ctx.BalanceItemsAgua(ReciboAtual.ID).ToList();
                if (!balanco.Any()) {
                    return;
                }

                foreach (var cota in ReciboAtual.Cotas.Where(c => c.Data == null)) {
                    var item = balanco.FirstOrDefault(i => i.Centavos == cota.PessoaID ||
                                                           i.Nome == cota.Nome ||
                                                           i.Nome == cota.Sobrenome);
                    if (item == null) {
                        continue;
                    }

                    cota.Data = item.Data;
                    counter++;
                }
            }
            bsRecibos.ResetBindings(false);
            dgvCotas.Refresh();
            MessageBox.Show($@"{counter} atualizações.", @"Pagamentos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButtonColect_Click(object sender, EventArgs e) {
            var data = DateTime.Today;
            if (PromptDialog.InputDate("Pagamento de Distribuição e coleta", "Data", ref data) != DialogResult.OK) {
                return;
            }

            ReciboAtual.Movimentos.Add(new Movimento()
            {
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

        private void dgvCotas_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var cota = (Cota)dgvCotas.Rows[e.RowIndex].DataBoundItem;
            //if (cota.Cobranca == 2) {
            //    e.CellStyle.ForeColor = Color.Yellow;
            //}
            if (e.ColumnIndex == 2 && cota.Cobranca == 2) {
                e.CellStyle.BackColor = Color.Khaki;
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

        private void dgvRecibos_SelectionChanged(object sender, EventArgs e) {
            if (dgvCotas.RowCount == 0) {
                return;
            }

            dgvCotas.Sort(dgvCotas.Columns[1], ListSortDirection.Ascending);
        }
        #endregion ----------------------------------------------------------------
    }
}
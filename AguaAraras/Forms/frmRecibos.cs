using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AguaAraras.Classes;

namespace AguaAraras {
    public partial class frmRecibos : Form {
        public List<Recibo> Recibos;
        private BindingSource _sourceRecibos;

        public SortableBindingList<Cota> Cotas;
        private BindingSource _sourceCotas;

        private Recibo ReciboAtual => Recibos[bindingSourceRecibos.Position];

        public frmRecibos() {
            InitializeComponent();
        }

        private void frmRecibos_Load(object sender, EventArgs e) {
            Recibos = Database.RecibosGet();
            _sourceRecibos = new BindingSource { DataSource = Recibos };
            bindingSourceRecibos.DataSource = _sourceRecibos;
            reciboBindingNavigatorSaveItem.Enabled = false;
            SetTotals();
        }

        private void bindingSourceRecibos_PositionChanged(object sender, EventArgs e) {
            ResetCotas();
            ((INotifyPropertyChanged)ReciboAtual).PropertyChanged -= Recibo_OnPropertyChanged;
            ((INotifyPropertyChanged)ReciboAtual).PropertyChanged += Recibo_OnPropertyChanged;
        }

        private void Recibo_OnPropertyChanged(object sender, EventArgs e) {
            reciboBindingNavigatorSaveItem.Enabled = true;
        }

        private void cotaDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            Cotas[e.RowIndex].Updated = true;
            _sourceCotas.ResetBindings(false);
            reciboBindingNavigatorSaveItem.Enabled = true;
            SetTotals();
        }

        private void cotaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!Cotas.Any() || Cotas.Count <= e.RowIndex) return;
            if (Cotas[e.RowIndex].Cobranca == 2)
                e.CellStyle.ForeColor = Color.DarkGreen;
            if (Cotas[e.RowIndex].Updated)
                e.CellStyle.BackColor = Color.Bisque;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            reciboBindingNavigatorSaveItem.Enabled = true;
        }

        private void reciboBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            bindingSourceRecibos.EndEdit();
            bindingSourceCotas.EndEdit();
            Database.ReciboUpdate(ReciboAtual,
                Cotas.Where(c => c.Updated).ToList());
            ResetCotas();
        }

        private void ResetCotas() {
            var reciboID = ReciboAtual.ID;
            Cotas = Database.CotasGet(reciboID);
            _sourceCotas = new BindingSource { DataSource = Cotas };
            bindingSourceCotas.DataSource = _sourceCotas;
            SetTotals();
            toolStripButtonColeta.Enabled = !Database.ColetaPaga(reciboID);
            reciboBindingNavigatorSaveItem.Enabled = false;
        }

        private void cobrancasImpressasToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport(Database.ReciboItensGet(ReciboAtual.ID).Where(i => i.Cobranca == 1).ToList(),
                "rptCobranca", "DataSetReciboItens", "Cobranças");
        }

        private void cobrancasEMailToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmCobrancaEmail(this.ParentForm, ReciboAtual.ID);
            frm.Show();
        }

        private void selecionadasToolStripMenuItem_Click(object sender, EventArgs e) {
            if (cotaDataGridView.SelectedRows.Count == 0) {
                MessageBox.Show(@"Nenhum nome foi selecionado.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var itens = Database.ReciboItensGet(ReciboAtual.ID);
            var selecionados =
            (from DataGridViewRow n in cotaDataGridView.SelectedRows
                select itens[n.Index]).ToList();
            frm.SetReport(selecionados, "rptCobranca", "DataSetReciboItens", "Cobranças");
        }

        private void cotaDataGridView_SelectionChanged(object sender, EventArgs e) {
            selecionadasToolStripMenuItem.Enabled = cotaDataGridView.SelectedRows.Count > 0;
        }

        private void recibosToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport(Database.ReciboItensGet(ReciboAtual.ID).Where(i => i.GerarRecibo).ToList(),
                "rptRecibo", "DataSetReciboItens", "Recibos");
        }

        private void fichaConferênciaToolStripMenuItem_Click(object sender, EventArgs e) {
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            frm.SetReport(Database.ReciboItensGet(ReciboAtual.ID).Where(i => i.Cobranca == 1).ToList(),
                "rptFichaConferencia", "DataSetReciboItens", "Ficha Conferência");
        }

        private void SetTotals() {
            labelTotal.Text = Cotas.Sum(c => c.Valor).ToString("N2");
            labelRecebido.Text = Cotas.Where(c => c.Data != null).Sum(c => c.Valor).ToString("N2");
            labelPendente.Text = Cotas.Where(c => c.Data == null).Sum(c => c.Valor).ToString("N2");
        }

        private void toolStripButtonPagamentos_Click(object sender, EventArgs e) {
            var itens = Database.GetBalanceItems(ReciboAtual.ID);
            var naoPagos = Cotas.Where(c => c.Data == null).ToList();
            var counter = 0;
            foreach (var np in naoPagos) {
                var item = itens.FirstOrDefault(i => i.Centavos == np.PessoaID || i.Nome == np.Nome);
                if (item == null) continue;
                np.Data = item.Data;
                np.Updated = true;
                counter++;
            }
            MessageBox.Show($@"{counter} atualizações.", @"Pagamentos",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            _sourceCotas.ResetBindings(false);
            reciboBindingNavigatorSaveItem.Enabled = naoPagos.Any(n => n.Updated);
        }

        private void toolStripButtonColeta_Click(object sender, EventArgs e) {
            var data = DateTime.Now;
            if (clsPromptDialog.InputDate("Pagamento de Distribuição e coleta", "Data", ref data) != DialogResult.OK) return;
            Database.ColetaAdd(ReciboAtual.ID, data);
            toolStripButtonColeta.Enabled = false;
        }
    }
}

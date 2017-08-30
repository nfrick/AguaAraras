using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class FrmBalanco : Form {
        SortableBindingList<Extrato> _extratos;
        private BindingSource _sourceExtratos;

        SortableBindingList<Balanco> _balancoMes;
        private BindingSource _sourceBalancoMes;

        SortableBindingList<Balanco> _balancoTrimestre;
        private BindingSource _sourceBalancoTrimestre;

        SortableBindingList<Balanco> _balancoAno;
        private BindingSource _sourceBalancoAno;

        public FrmBalanco() {
            InitializeComponent();
        }

        private void FrmBalanco_Load(object sender, EventArgs e) {
            _balancoAno = Database.BalancoGet("YEAR");
            _sourceBalancoAno = new BindingSource {DataSource = _balancoAno};
            bindingSourceBalancoAno.DataSource = _sourceBalancoAno;

            _balancoTrimestre = Database.BalancoGet("QUARTER");
            _sourceBalancoTrimestre = new BindingSource {DataSource = _balancoTrimestre};
            bindingSourceBalancoTrimestre.DataSource = _sourceBalancoTrimestre;

            _balancoMes = Database.BalancoGet("MONTH");
            _sourceBalancoMes = new BindingSource {DataSource = _balancoMes};
            bindingSourceBalancoMes.DataSource = _sourceBalancoMes;

            _extratos = Database.ExtratoGet();
            _sourceExtratos = new BindingSource {DataSource = _extratos};
            bindingSourceExtratos.DataSource = _sourceExtratos;
        }

        private void extratoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!_extratos.Any() || _extratos.Count <= e.RowIndex)
                return;
            var extrato = _extratos[e.RowIndex];
            if (extratoDataGridView.Columns[e.ColumnIndex].HeaderText == @"Valor" && extrato.Valor < 0)
                e.CellStyle.ForeColor = Color.Red;
        }

        private void balancoMesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!_balancoMes.Any() || _balancoMes.Count <= e.RowIndex)
                return;
            var balanco = _balancoMes[e.RowIndex];
            if (balancoMesDataGridView.Columns[e.ColumnIndex].HeaderText == @"Saldo" && balanco.Saldo < 0)
                e.CellStyle.ForeColor = Color.Red;
        }

        private void balancoTrimestreDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!_balancoTrimestre.Any() || _balancoTrimestre.Count <= e.RowIndex)
                return;
            var balanco = _balancoTrimestre[e.RowIndex];
            if (balancoTrimestreDataGridView.Columns[e.ColumnIndex].HeaderText == @"Saldo" && balanco.Saldo < 0)
                e.CellStyle.ForeColor = Color.Red;
        }

        private void balancoAnoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!_balancoAno.Any() || _balancoAno.Count <= e.RowIndex)
                return;
            var balanco = _balancoAno[e.RowIndex];
            if (balancoAnoDataGridView.Columns[e.ColumnIndex].HeaderText == "Saldo" && balanco.Saldo < 0)
                e.CellStyle.ForeColor = Color.Red;
        }

        private void toolStripButtonExtrato_Click(object sender, EventArgs e) {
            var extratoList = _extratos.OrderBy(t => t.Data).ThenBy(t => t.ID);
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var rpt = "rptExtrato" + ((ToolStripButton)sender).Name.Substring(22);
            frm.SetReport(extratoList.ToList(), rpt, "DataSetExtrato");
        }
    }
}

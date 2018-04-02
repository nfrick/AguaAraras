using System;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using OfficeOpenXml.Style.XmlAccess;

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
            _sourceBalancoAno = new BindingSource { DataSource = _balancoAno };
            bindingSourceBalancoAno.DataSource = _sourceBalancoAno;

            _balancoTrimestre = Database.BalancoGet("QUARTER");
            _sourceBalancoTrimestre = new BindingSource { DataSource = _balancoTrimestre };
            bindingSourceBalancoTrimestre.DataSource = _sourceBalancoTrimestre;

            _balancoMes = Database.BalancoGet("MONTH");
            _sourceBalancoMes = new BindingSource { DataSource = _balancoMes };
            bindingSourceBalancoMes.DataSource = _sourceBalancoMes;

            _extratos = Database.ExtratoGet();
            _sourceExtratos = new BindingSource { DataSource = _extratos };
            bindingSourceExtratos.DataSource = _sourceExtratos;

            dgvAno.Tag = dgvExtrato.Tag = 3;
            dgvMes.Tag = dgvTrimestre.Tag = 4;
            foreach (var ctrl in Controls) {
                if (!(ctrl is DataGridView)) continue;
                var dgv = (DataGridView)ctrl;
                for (var col = (int)dgv.Tag; col < dgv.Columns.Count; col++)
                    dgv.Columns[col].DefaultCellStyle.Format = "N2";
            }
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var dgv = (DataGridView)sender;
            if (dgv.Rows.Count == 0) return;
            if (e.ColumnIndex < (int)dgv.Tag) return;
            if ((decimal)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value < 0)
                e.CellStyle.ForeColor = Color.Red;
        }

        private void toolStripButtonExtrato_Click(object sender, EventArgs e) {
            var extratoList = _extratos.OrderBy(t => t.Data).ThenBy(t => t.ID).ToList();
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var rpt = "rptExtrato" + ((ToolStripButton)sender).Name.Substring(22);
            frm.SetReport(extratoList, rpt, "DataSetExtrato", "Extrato");
        }
    }
}

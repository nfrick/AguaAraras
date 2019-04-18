using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;

namespace AguaAraras {
    public partial class FrmBalanco : Form {
        SortableBindingList<Extrato> _extrato;

        public FrmBalanco() {
            InitializeComponent();
        }

        private void FrmBalanco_Load(object sender, EventArgs e) {
            _extrato = Database.ExtratoGet();

            bs_BalancoAno.DataSource = new BindingSource { DataSource = Database.BalancoGet("YEAR") };
            bs_BalancoTrimestre.DataSource = new BindingSource { DataSource = Database.BalancoGet("QUARTER") };
            bs_BalancoMes.DataSource = new BindingSource { DataSource = Database.BalancoGet("MONTH") };
            bs_Extratos.DataSource = new BindingSource { DataSource = _extrato };

            bs_xTabDataAnoReal.DataSource = new BindingSource { DataSource = Database.XTabDataGet("sp_XtabAnoReal") };
            bs_xTabDataAnoRecibo.DataSource = new BindingSource { DataSource = Database.XTabDataGet("sp_XtabAnoRecibo") };
            bs_xTabDataTrimReal.DataSource = new BindingSource { DataSource = Database.XTabDataGet("sp_XtabTrimestreReal") };
            bs_xTabDataTrimRecibo.DataSource = new BindingSource { DataSource = Database.XTabDataGet("sp_XtabTrimestreRecibo") };

            dgvAno.Tag = 1;
            dgvExtrato.Tag = 3;
            dgvMes.Tag = 2;
            dgvTrimestre.Tag = 2;

            foreach (var dgv in tableLayoutPanel3.Controls.OfType<DataGridView>()) {
                dgv.Tag = 2;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[0].Width = 60;
                for (var i = 1; i < dgv.ColumnCount; i++) {
                    dgv.Columns[i].Width = 73;
                    dgv.Columns[i].DefaultCellStyle.Format = "N2";
                    dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        public IEnumerable<Control> GetAll(Control control, Type type) {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var dgv = (DataGridView)sender;
            if (dgv.Rows.Count == 0 || e.ColumnIndex < dgv.ColumnCount-1) //(e.ColumnIndex < (int)dgv.Tag)) {
                return;

            if ((decimal)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value < 0) {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void toolStripButtonExtrato_Click(object sender, EventArgs e) {
            var extratoList = _extrato.OrderBy(t => t.Data).ThenBy(t => t.ID).ToList();
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var rpt = "rptExtrato" + ((ToolStripButton)sender).Name.Substring(22);
            frm.SetReport(extratoList, rpt, "DataSetExtrato", "Extrato");
        }
    }
}
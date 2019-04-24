using DataLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmBalanco : Form {
        private readonly List<sp_Extrato_Result> _extratoList = new List<sp_Extrato_Result>();

        public frmBalanco() {
            InitializeComponent();
        }

        private void frmBalanco_Load(object sender, EventArgs e) {
            using (var ctx = new AguaArarasEntities()) {
                var extrato = ctx.sp_Extrato();
                foreach (var item in extrato)
                    _extratoList.Add(new sp_Extrato_Result() {
                        RID = item.RID,
                        Data = item.Data,
                        Valor = (decimal)item.Valor,
                        Descricao = item.Descricao,
                        Tipo = item.Tipo,
                        Saldo = (decimal)item.Saldo
                    });

                bs_BalancoAno.DataSource = new BindingSource { DataSource = ctx.sp_Balanco("YEAR") };
                bs_BalancoTrimestre.DataSource = new BindingSource { DataSource = ctx.sp_Balanco("QUARTER") };
                bs_BalancoMes.DataSource = new BindingSource { DataSource = ctx.sp_Balanco("MONTH") };

                extrato = ctx.sp_Extrato();
                bs_Extratos.DataSource = new BindingSource { DataSource = extrato };

                bs_xTabDataAnoReal.DataSource = new BindingSource { DataSource = ctx.sp_Xtab("ANO REAL") };
                bs_xTabDataAnoRecibo.DataSource = new BindingSource { DataSource = ctx.sp_Xtab("ANO RECIBO") };
                bs_xTabDataTrimReal.DataSource = new BindingSource { DataSource = ctx.sp_Xtab("TRIM REAL") };
                bs_xTabDataTrimRecibo.DataSource = new BindingSource { DataSource = ctx.sp_Xtab("TRIM RECIBO") };
            }
            //dgvAno.Tag = 1;
            //dgvExtrato.Tag = 3;
            //dgvMes.Tag = 2;
            //dgvTrimestre.Tag = 2;

            foreach (var dgv in tableLayoutPanel3.Controls.OfType<DataGridView>()) {
                //dgv.Tag = 2;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv.Columns[0].Width = 60;
                for (var i = 1; i < dgv.ColumnCount; i++) {
                    dgv.Columns[i].Width = 73;
                    dgv.Columns[i].DefaultCellStyle.Format = "N2";
                    dgv.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        //public IEnumerable<Control> GetAll(Control control, Type type) {
        //    var controls = control.Controls.Cast<Control>();

        //    return controls.SelectMany(ctrl => GetAll(ctrl, type))
        //        .Concat(controls)
        //        .Where(c => c.GetType() == type);
        //}

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            var dgv = (DataGridView)sender;
            if (dgv.Rows.Count == 0 || e.ColumnIndex < dgv.ColumnCount - 1) //(e.ColumnIndex < (int)dgv.Tag)) {
{
                return;
            }

            if ((decimal)dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value < 0) {
                e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void toolStripButtonExtrato_Click(object sender, EventArgs e) {       
            var frm = new frmRelatorio { MdiParent = this.ParentForm };
            var rpt = "rptExtrato" + ((ToolStripButton)sender).Name.Substring(22);
            frm.SetReport(_extratoList, rpt, "DataSetExtrato", "Extrato");
        }
    }
}
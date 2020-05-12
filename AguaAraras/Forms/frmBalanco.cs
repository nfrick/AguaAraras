using DataLayer;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmBalanco : Form {
        private List<ExtratoItem> _extrato; // = new List<sp_Extrato_Result>();

        // Anos de início e término para relatórios
        private int _inicio;
        private int _termino;

        public frmBalanco() {
            InitializeComponent();
            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";
        }

        private void frmBalanco_Load(object sender, EventArgs e) {
            using (var ctx = new AguaArarasEntities()) {
                _extrato = ctx.sp_Extrato(null, null).Select(x => (ExtratoItem)x.Clone()).ToList();

                var anos = _extrato.Where(m => m.Data != null)
                    .Select(m => m.Data.ToString("yyyy")).Distinct().ToArray();
                toolStripComboBoxInicio.Items.AddRange(anos);
                toolStripComboBoxTermino.Items.AddRange(anos);
                toolStripComboBoxInicio.SelectedIndex = 4;
                toolStripComboBoxTermino.SelectedIndex = 0;

                bs_BalancoAno.DataSource = new BindingSource { DataSource = ctx.sp_Balanco("YEAR") };
                bs_BalancoTrimestre.DataSource = new BindingSource { DataSource = ctx.sp_Balanco("QUARTER") };
                bs_BalancoMes.DataSource = new BindingSource { DataSource = ctx.sp_Balanco("MONTH") };
                bs_Extratos.DataSource = new BindingSource { DataSource = _extrato };

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

        public IEnumerable<Control> GetAllControls(Control control, Type type) {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAllControls(ctrl, type))
                .Concat(controls)
                .Where(c => c.GetType() == type);
        }

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

            frm.SetLocalReport(rpt, "Extrato", "DataSetExtrato", _extrato
                .SkipWhile(m => m.Data.Year > _termino)
                .TakeWhile(m => m.Data.Year >= _inicio));
            frm.Show();
        }

        private void toolStripComboBoxInicio_SelectedIndexChanged(object sender, EventArgs e) {
            _inicio = int.Parse((string)toolStripComboBoxInicio.SelectedItem);
        }

        private void toolStripComboBoxTermino_SelectedIndexChanged(object sender, EventArgs e) {
            _termino = int.Parse((string)toolStripComboBoxTermino.SelectedItem);
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e) {
            if (SFD.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            var pck = new ExcelPackage(new FileInfo(SFD.FileName));

            foreach (DataGridView dgv in GetAllControls(this, typeof(DataGridView))) {
                var ws = pck.Workbook.Worksheets.Add(dgv.Name.Substring(3));
                ws.View.ShowGridLines = false;

                foreach (DataGridViewColumn coluna in dgv.Columns) {
                    ws.Cells[1, coluna.Index + 1].Value = coluna.HeaderText;
                }

                foreach (DataGridViewRow linha in dgv.Rows) {
                    foreach (DataGridViewCell cell in linha.Cells) {
                        ws.Cells[linha.Index + 2, cell.ColumnIndex + 1].Value = cell.Value;
                    }
                }

                foreach (DataGridViewColumn coluna in dgv.Columns) {
                    if (coluna.HeaderText == @"Data") {
                        ws.Cells[2, coluna.Index + 1,
                        dgv.RowCount + 1, coluna.Index + 1].Style.Numberformat.Format = "dd/MM/yyyy";
                    }
                    else if (coluna.DefaultCellStyle.Format == "N2") {
                        ws.Cells[2, coluna.Index + 1,
                            dgv.RowCount + 1, coluna.Index + 1].Style.Numberformat.Format = "#,##0.00";
                    }
                }

                ws.Cells.AutoFitColumns(0);

                var range = ws.Cells[1, 1, dgv.RowCount + 1, dgv.ColumnCount];
                var table = ws.Tables.Add(range, dgv.Name.Substring(3));
                table.ShowTotal = true;
                table.TableStyle = TableStyles.Light1;

                ws.View.FreezePanes(2, 1);
                pck.Save();
            }

            MessageBox.Show(@"Balanço exportado.", @"Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
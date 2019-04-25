using DataLayer;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmMovimentos : Form {
        public frmMovimentos() {
            InitializeComponent();

            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";

            var tipos =
                (from Movimento m in entityDataSourceMovimentos.EntitySets["Movimentos"]
                 group m by m.Tipo into g
                 select g.Key).OrderBy(t => t).ToArray();

            dataGridViewComboBoxColumnTipo.Items.AddRange(tipos);

            toolStripComboBoxTipo.Items.Add("Todos");
            toolStripComboBoxTipo.Items.AddRange(tipos);
            toolStripComboBoxTipo.SelectedIndex = 0;

            toolStripComboBoxErros.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxErros.SelectedIndex = 0;

        }

        private void frmMovimentos_Load(object sender, EventArgs e) {
            dgvMovimentos.Sort(dgvMovimentos.Columns[0], ListSortDirection.Descending);
        }

        #region TOLLSTRIP -------------------------------------
        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            entityDataSourceMovimentos.SaveChanges();
        }

        private void toolStripButtonNovo_Click(object sender, EventArgs e) {
            dgvMovimentos.Rows.OfType<DataGridViewRow>().Last().Selected = true;
            dgvMovimentos.CurrentCell = dgvMovimentos.Rows.OfType<DataGridViewRow>().Last().Cells.OfType<DataGridViewCell>().First();
            dgvMovimentos.BeginEdit(false);
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e) {
            if (SFD.ShowDialog() == DialogResult.Cancel) {
                return;
            }

            using (var ctx = new AguaArarasEntities()) {
                var movimentos = ctx.sp_Movimentos();

                var pck = new ExcelPackage(new FileInfo(SFD.FileName));
                var ws = pck.Workbook.Worksheets.Add("Movimentos");
                ws.View.ShowGridLines = false;

                var col = 1;
                ws.Cells[1, col++].Value = "ID";
                ws.Cells[1, col++].Value = "Tipo";
                ws.Cells[1, col++].Value = "Data";
                ws.Cells[1, col++].Value = "Recibo";
                ws.Cells[1, col++].Value = "Nome";
                ws.Cells[1, col++].Value = "Histórico";
                ws.Cells[1, col++].Value = "Valor";
                ws.Cells[1, col++].Value = "Observações";

                var row = 2;
                foreach (var item in movimentos) {
                    col = 1;
                    ws.Cells[row, col++].Value = item.ID;
                    ws.Cells[row, col++].Value = item.Tipo;
                    ws.Cells[row, col++].Value = item.Data;
                    ws.Cells[row, col++].Value = item.Recibo;
                    ws.Cells[row, col++].Value = item.Nome;
                    ws.Cells[row, col++].Value = item.Historico;
                    ws.Cells[row, col++].Value = item.Valor;
                    ws.Cells[row++, col].Value = item.Observacoes;
                }

                row--;
                ws.Cells[$"C2:C{row}"].Style.Numberformat.Format = "dd-MM-yyyy";
                ws.Cells[$"G2:G{row}"].Style.Numberformat.Format = "#,##0.00";
                ws.Cells.AutoFitColumns(0);

                var range = ws.Cells[1, 1, row, col];
                var table = ws.Tables.Add(range, "table1");
                table.ShowTotal = true;
                table.TableStyle = TableStyles.Light1;

                ws.View.FreezePanes(2, 1);
                pck.Save();

                MessageBox.Show(@"Movimentos exportados.", @"Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButtonProcurar_Click(object sender, EventArgs e) {
            var columns = dgvMovimentos.Columns.Cast<DataGridViewColumn>().Where(c => c.Visible).Select(c => c.Index)
                .ToArray();
            var row = dgvMovimentos.CurrentRow.Index;
            var target = toolStripTextBoxProcurar.Text.ToLower();
            var found = false;
            do {
                var Row = dgvMovimentos.Rows[++row];
                foreach (var col in columns) {
                    found = Row.Cells[col].FormattedValue.ToString().ToLower().Contains(target);
                    if (!found) {
                        continue;
                    }

                    dgvMovimentos.CurrentCell = dgvMovimentos.Rows[row].Cells[col];
                    break;
                }
                if (found) {
                    return;
                }
            } while (row < dgvMovimentos.RowCount - 1);
            MessageBox.Show($"'{target}' não encontrado", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripComboBoxTipo_SelectedIndexChanged(object sender, EventArgs e) {
            if (toolStripComboBoxTipo.Text == @"Todos") {
                dgvMovimentos.DataSource = entityDataSourceMovimentos;
                dgvMovimentos.DataMember = "Movimentos";
                toolStripButtonNovo.Enabled = true;
            }
            else {
                var q =
                    from DataLayer.Movimento m in entityDataSourceMovimentos.EntitySets["Movimentos"]
                    where m.Tipo == toolStripComboBoxTipo.Text
                    orderby m.Data descending
                    select m;

                // create BindingList (sortable/filterable)
                var bindingList = entityDataSourceMovimentos.CreateView(q);

                // assign BindingList to grid
                dgvMovimentos.DataSource = bindingList;
                toolStripButtonNovo.Enabled = false;
            }
        }

        private void toolStripComboBoxErros_SelectedIndexChanged(object sender, EventArgs e) {
            var positivos = new[] { "cota", "receita" };
            IQueryable<DataLayer.Movimento> q;
            var es = entityDataSourceMovimentos.EntitySets["Movimentos"];
            switch (toolStripComboBoxErros.SelectedIndex) {
                case 0:
                    dgvMovimentos.DataSource = entityDataSourceMovimentos;
                    dgvMovimentos.DataMember = "Movimentos";
                    toolStripButtonNovo.Enabled = true;
                    return;
                case 1: // Receitas negativas
                    q = from DataLayer.Movimento m in es
                        where positivos.Contains(m.Tipo) && m.Valor < 0
                        orderby m.Data descending
                        select m;
                    break;
                case 2: // Despesas positivas
                    q = from DataLayer.Movimento m in es
                        where !positivos.Contains(m.Tipo) && m.Valor > 0
                        orderby m.Data descending
                        select m;
                    break;
                case 3:
                    q = (from DataLayer.Movimento m in es
                         where m.Tipo == "vergilio" && m.Data != null && m.Historico.StartsWith("salário")
                         select m)
                        .GroupBy(m => new { Y = ((DateTime)m.Data).Year, M = ((DateTime)m.Data).Month }, m => m)
                        .Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                case 4:
                    q = (from DataLayer.Movimento m in es
                         where m.Tipo == "vergilio"
                         orderby m.Data descending
                         select m).GroupBy(m => m.Historico, m => m).Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                case 5:
                    q = (from DataLayer.Movimento m in es
                         where m.Tipo == "carlos"
                         orderby m.Data descending
                         select m).GroupBy(m => m.Recibo, m => m).Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                case 6:
                    q = (from DataLayer.Movimento m in es
                         where m.Tipo == "carlos"
                         orderby m.Data descending
                         select m).GroupBy(m => m.Historico, m => m).Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                default:
                    return;
            }

            if (!q.Any()) {
                MessageBox.Show("Nenhum registro com erro foi encontrado.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // create BindingList (sortable/filterable)
            var bindingList = entityDataSourceMovimentos.CreateView(q);

            // assign BindingList to grid
            dgvMovimentos.DataSource = bindingList;
            toolStripButtonNovo.Enabled = false;
        }
        #endregion --------------------------------------------

        private void dgvMovimentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex != 3 || dgvMovimentos.Rows[e.RowIndex].Cells[3].Value == null ||
                (decimal)dgvMovimentos.Rows[e.RowIndex].Cells[3].Value >= 0) {
                return;
            }
            e.CellStyle.ForeColor = Color.Red;
        }

        private void toolStripButtonManutencao_Click(object sender, EventArgs e) {
            using (var ctx = new AguaArarasEntities()) {
                ctx.sp_ManutencaoAdd();
            }
            entityDataSourceMovimentos.Refresh();
        }
    }
}
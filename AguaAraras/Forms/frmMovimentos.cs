using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Table;

namespace AguaAraras {
    public partial class FrmMovimentos : Form {
        private SortableBindingList<Movimento> _movimentos;
        private readonly List<Movimento> _deleted = new List<Movimento>();
        private BindingSource _sourceMovimentos;

        public FrmMovimentos() {
            InitializeComponent();
        }

        private void frmMovimentos_Load(object sender, EventArgs e) {
            LoadData();

            var tipos = _movimentos.GroupBy(p => p.Tipo)
                                    .Select(g => g.Key.ToString())
                                    .OrderBy(x => x)
                                    .ToArray();
            dataGridViewComboBoxColumnTipo.Items.AddRange(tipos);
            toolStripComboBoxTipo.Items.Add("Todos");
            toolStripComboBoxTipo.Items.AddRange(tipos);
            toolStripComboBoxTipo.SelectedIndex = 0;

            var nomes = _movimentos.Where(p => p.Tipo == "cota")
                                    .GroupBy(p => p.Nome)
                                    .Select(g => g.Key.ToString())
                                    .OrderBy(x => x)
                                    .ToArray();
            toolStripComboBoxNome.Items.Add("Todos");
            toolStripComboBoxNome.Items.AddRange(nomes);
            toolStripComboBoxNome.SelectedIndex = 0;

            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = @"Excel Files|*.xlsx";
        }

        private void LoadData() {
            _movimentos = Database.MovimentosGet();
            _sourceMovimentos = new BindingSource { DataSource = _movimentos };
            bindingSourceMovimentos.DataSource = _sourceMovimentos;
        }

        private void movimentoDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!_movimentos.Any() || _movimentos.Count <= e.RowIndex)
                return;
            var mov = _movimentos[e.RowIndex];
            if (mov.Updated)
                e.CellStyle.BackColor = Color.Bisque;
            if (movimentoDataGridView.Columns[e.ColumnIndex].HeaderText == @"Valor" && mov.Valor < 0)
                e.CellStyle.ForeColor = Color.Red;

        }

        private void movimentoDataGridView_RowEnter(object sender, DataGridViewCellEventArgs e) {
            bool flag = _movimentos[e.RowIndex].Tipo == "cota";
            movimentoDataGridView.Rows[e.RowIndex].ReadOnly = flag;
            bindingNavigatorDeleteItem.Enabled = !flag;
        }

        private void movimentoDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            if (_movimentos[e.Row.Index].Tipo == "cota")
                e.Cancel = true;
            else
                _deleted.Add(_movimentos[e.Row.Index]);
        }

        private void movimentoDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) return;
            _movimentos[e.RowIndex].Updated = true;
            _sourceMovimentos.ResetBindings(false);
            bindingNavigatorSaveItem.Enabled = true;
        }

        private void toolStripComboBoxTipos_SelectedIndexChanged(object sender, EventArgs e) {
            bindingSourceMovimentos.Filter = toolStripComboBoxTipo.Text == @"Todos" ? "" : $@"Tipo = '{toolStripComboBoxTipo.Text}'";
        }

        private void toolStripComboBoxNome_SelectedIndexChanged(object sender, EventArgs e) {
            bindingSourceMovimentos.Filter = toolStripComboBoxNome.Text == @"Todos" ? "" : $@"Nome = '{toolStripComboBoxNome.Text}'";
        }

        private void toolStripButtonHistorico_Click(object sender, EventArgs e) {
            bindingSourceMovimentos.Filter = toolStripTextBoxHistorico.Text == string.Empty ? "" : $@"Historico = '{toolStripTextBoxHistorico.Text}'";
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            var updated = _movimentos.Where(m => m.Updated).ToList();
            if (!Database.MovimentosUpdate(updated, _deleted)) return;
            foreach (var mov in updated)
                mov.Updated = false;
            _deleted.Clear();
            bindingNavigatorSaveItem.Enabled = false;
            bindingSourceMovimentos.ResetBindings(false);
        }

        private void toolStripButtonVergilio_Click(object sender, EventArgs e) {
            Database.VergilioAdd();
            LoadData();
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e) {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            var items = _movimentos.OriginalList;
            var pck = new ExcelPackage(new FileInfo(saveFileDialog1.FileName));
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
            foreach (var item in items) {
                col = 1;
                ws.Cells[row, col++].Value = item.ID;
                ws.Cells[row, col++].Value = item.Tipo;
                ws.Cells[row, col++].Value = item.Data;
                ws.Cells[row, col++].Value = item.Recibo;
                ws.Cells[row, col++].Value = item.Nome;
                ws.Cells[row, col++].Value = item.Historico;
                ws.Cells[row, col++].Value = item.Valor;
                ws.Cells[row++, col++].Value = item.Observacoes;
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

            MessageBox.Show(@"Data exported.", @"Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

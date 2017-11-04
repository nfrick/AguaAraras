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

            toolStripComboBoxErros.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxErros.SelectedIndex = 0;

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

            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";
        }

        private void frmMovimentos_Load(object sender, EventArgs e) {
            Width = movimentoBindingNavigator.Items.Cast<ToolStripItem>().Sum(i => i.Width + 2);
        }

        private void LoadData() {
            var positivos = new[] { "cota", "receita" };
            var source = new List<Movimento>();
            switch (toolStripComboBoxErros.SelectedIndex) {
                case 0:
                    _movimentos = Database.MovimentosGet();
                    _sourceMovimentos = new BindingSource { DataSource = _movimentos };
                    bindingSourceMovimentos.DataSource = _sourceMovimentos;
                    return;
                case 1:
                    source = Database.MovimentosGet().Where(m => positivos.Contains(m.Tipo) && m.Valor < 0).ToList();
                    break;
                case 2:
                    source = Database.MovimentosGet().Where(m => !positivos.Contains(m.Tipo) && m.Valor > 0).ToList();
                    break;
                case 3:
                    source = Database.MovimentosGet().Where(m => m.Tipo == "vergilio" && m.Historico.StartsWith("salário")).GroupBy(m => $"{m.Data:yyyy-MM}", m => m).Where(v => v.Count() != 1).SelectMany(v => v).ToList();
                    break;
                case 4:
                    source = Database.MovimentosGet().Where(m => m.Tipo == "vergilio").GroupBy(m => m.Historico, m => m).Where(v => v.Count() != 1).SelectMany(v => v).ToList();
                    break;
                case 5:
                    source = Database.MovimentosGet().Where(m => m.Tipo == "carlos").GroupBy(m => m.Recibo, m => m).Where(v => v.Count() != 1).SelectMany(v => v).ToList();
                    break;
                case 6:
                    source = Database.MovimentosGet().Where(m => m.Tipo == "carlos").GroupBy(m => m.Historico, m => m).Where(v => v.Count() != 1).SelectMany(v => v).ToList();
                    break;
                default:
                    break;
            }
            if (!source.Any()) {
                MessageBox.Show("Nenhum registro com erro foi encontrado.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _movimentos = new SortableBindingList<Movimento>();
            foreach (var m in source)
                _movimentos.Add(m);
            _sourceMovimentos = new BindingSource { DataSource = _movimentos };
            bindingSourceMovimentos.DataSource = _sourceMovimentos;
        }

        private void dgvMovimentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (!_movimentos.Any() || _movimentos.Count <= e.RowIndex)
                return;
            var mov = _movimentos[e.RowIndex];
            if (mov.Updated)
                e.CellStyle.BackColor = Color.Bisque;
            if (dgvMovimentos.Columns[e.ColumnIndex].HeaderText == @"Valor" && mov.Valor < 0)
                e.CellStyle.ForeColor = Color.Red;

        }

        private void dgvMovimentos_RowEnter(object sender, DataGridViewCellEventArgs e) {
            var flag = _movimentos[e.RowIndex].Tipo == "cota";
            dgvMovimentos.Rows[e.RowIndex].ReadOnly = flag;
            bindingNavigatorDeleteItem.Enabled = !flag;
        }

        private void dgvMovimentos_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            e.Cancel = _movimentos[e.Row.Index].Tipo == "cota";
            if (!e.Cancel)
                _deleted.Add(_movimentos[e.Row.Index]);
        }

        private void dgvMovimentos_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
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

        private void toolStripButtonVergilio_Click(object sender, EventArgs e) {
            Database.VergilioAdd();
            LoadData();
        }

        private void toolStripButtonExcel_Click(object sender, EventArgs e) {
            if (SFD.ShowDialog() == DialogResult.Cancel)
                return;

            var items = _movimentos.OriginalList;
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

        private void toolStripComboBoxErros_SelectedIndexChanged(object sender, EventArgs e) {
            LoadData();
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
    }
}

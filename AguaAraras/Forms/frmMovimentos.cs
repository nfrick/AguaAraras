using DataLayer;
using DbContextExtensions;
using OfficeOpenXml;
using OfficeOpenXml.Table;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmMovimentos : Form {

        private readonly AguaArarasEntities _ctx = new AguaArarasEntities();

        public frmMovimentos() {
            InitializeComponent();

            _ctx.Movimentos.Load();

            SFD.DefaultExt = "xlsx";
            SFD.Filter = @"Excel Files|*.xlsx";

            var tipos = _ctx.sp_TiposMovimento().ToArray();
            dataGridViewComboBoxColumnTipo.Items.AddRange(tipos);

            toolStripComboBoxTipo.Items.Add("Todos");
            toolStripComboBoxTipo.Items.AddRange(tipos);
            toolStripComboBoxTipo.SelectedIndex = 0;

            toolStripComboBoxErros.ComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            toolStripComboBoxErros.SelectedIndex = 0;

            //https://stackoverflow.com/questions/4588359/implementing-collectionchanged
            //_ctx.Movimentos.Local.CollectionChanged += LocalOnCollectionChanged;
        }

        //private void LocalOnCollectionChanged(object sender, NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs) {
        //    toolStripButtonSave.Enabled = true;
        //}

        private void frmMovimentos_Load(object sender, EventArgs e) {
            dgvMovimentos.Sort(dgvMovimentos.Columns[0], ListSortDirection.Descending);
        }

        #region TOLLSTRIP -------------------------------------
        private void toolStripButtonSave_Click(object sender, EventArgs e) {
            dgvMovimentos.EndEdit();
            if (!_ctx.SaveChanges(out var message)) {
                MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            toolStripButtonSave.Enabled = false;
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

            var movimentos = _ctx.sp_Movimentos();

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
                bsMovimentos.DataSource = _ctx.Movimentos.Local.ToBindingList();
            }
            else {
                SetBindingSource(_ctx.Movimentos.Local
                    .Where(m => m.Tipo == toolStripComboBoxTipo.Text));
            }
        }

        private void SetBindingSource(IEnumerable<Movimento> source) {
            //foreach (var item in source) {
            //    item.PropertyChanged += OnItemPropertyChanged;
            //}
            dgvMovimentos.DataSource = null;
            bsMovimentos.DataSource = new ObservableListSource<Movimento>(source).ToBindingList();
            dgvMovimentos.DataSource = bsMovimentos;
        }

        //private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e) {
        //    toolStripButtonSave.Enabled = true;
        //}

        private void toolStripComboBoxErros_SelectedIndexChanged(object sender, EventArgs e) {
            var positivos = new[] { "Cota", "Receita" };
            IEnumerable<Movimento> q;
            var Movimentos = _ctx.Movimentos.Local;
            switch (toolStripComboBoxErros.SelectedIndex) {
                case 0:
                    bsMovimentos.DataSource = Movimentos.ToBindingList();
                    return;
                case 1: // Receitas negativas
                    q = Movimentos.Where(m => positivos.Contains(m.Tipo) && m.Valor < 0);
                    break;
                case 2: // Despesas positivas
                    q = Movimentos.Where(m => !positivos.Contains(m.Tipo) && m.Valor > 0);
                    break;
                case 3:  // Manutenção duplicado (mês)
                    q = Movimentos.Where(m => m.Tipo == "Manutenção" && m.Data != null && m.Historico.StartsWith("pagamento"))
                            .GroupBy(m => new { Y = ((DateTime)m.Data).Year, M = ((DateTime)m.Data).Month }, m => m)
                            .Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                case 4:  // Manutenção duplicado (histórico)
                    q = Movimentos.Where(m => m.Tipo == "Manutenção")
                            .GroupBy(m => m.Historico, m => m).Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                case 5:  // Cobrança duplicado (trimestre)
                    q = Movimentos.Where(m => m.Tipo == "Cobrança")
                         .GroupBy(m => m.Recibo, m => m).Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                case 6:  // Cobrança duplicado (histórico)
                    q = Movimentos.Where(m => m.Tipo == "Cobrança")
                         .GroupBy(m => m.Historico, m => m).Where(v => v.Count() != 1).SelectMany(v => v);
                    break;
                default:
                    return;
            }

            SetBindingSource(q);

            if (!q.Any()) {
                MessageBox.Show("Nenhum registro com erro foi encontrado.", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void toolStripButtonManutencao_Click(object sender, EventArgs e) {
            _ctx.sp_ManutencaoAdd();
            _ctx.Movimentos.Load();
            bsMovimentos.DataSource = _ctx.Movimentos.Local.ToBindingList();
        }

        #endregion --------------------------------------------

        private void dgvMovimentos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {
            if (e.ColumnIndex != 3 || dgvMovimentos.Rows[e.RowIndex].Cells[3].Value == null ||
                (decimal)dgvMovimentos.Rows[e.RowIndex].Cells[3].Value >= 0) {
                return;
            }
            e.CellStyle.ForeColor = Color.Red;
        }

        private void dgvMovimentos_DataSourceChanged(object sender, EventArgs e) {
            if (dgvMovimentos.DataSource != null) {
                dgvMovimentos.Sort(dgvMovimentos.Columns[0], ListSortDirection.Descending);
            }
        }

        private void dgvMovimentos_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
            toolStripButtonSave.Enabled = _ctx.ChangeTracker.HasChanges();
        }
    }
}
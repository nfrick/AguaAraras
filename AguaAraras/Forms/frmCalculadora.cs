using System;
using System.Drawing;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmCalculadora : Form {
        public static decimal Constante { get; } = 0.059414991m;

        public frmCalculadora() {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e) {
            numericUpDownSalario.Value = Database.VergilioGetLastPayment();
            numericUpDownTomadas.Value = Database.Tomadas();
            CalcularMensalidade();
        }

        private void numericUpDownSalario_ValueChanged(object sender, EventArgs e) {
            CalcularMensalidade();
        }

        private void radioButtonCalculado_CheckedChanged(object sender, EventArgs e) {
            CalcularDetalhes();
        }

        private void numericUpDownMensalidade_ValueChanged(object sender, EventArgs e) {
            CalcularDetalhes();
        }

        private void CalcularMensalidade() {
            var mensalidade = Constante * numericUpDownSalario.Value;
            labelCalculado.Text = $@"{mensalidade:C2}";
            numericUpDownMensalidade.Value = (decimal)Math.Ceiling(mensalidade / 5) * 5;
            CalcularDetalhes();
        }

        private void CalcularDetalhes() {
            var mensalidade = radioButtonCalculado.Checked
                ? Constante * numericUpDownSalario.Value
                : numericUpDownMensalidade.Value;

            var arrecadacao = 12 * numericUpDownTomadas.Value * mensalidade;
            var vergilio = 13 * numericUpDownSalario.Value;
            var cobranca = 8 * mensalidade;
            var reserva = arrecadacao - (vergilio + cobranca);
            labelTotalDesc.Text = $@"12 * {numericUpDownTomadas.Value} * {mensalidade:C2} =";
            labelTotalValor.Text = $@"{arrecadacao:C2}";

            labelVergilioDesc.Text = $@"13 * {numericUpDownSalario.Value:C2} =";
            labelVergilioValor.Text = $@"{vergilio:C2}";

            labelCobrancaDesc.Text = $@"4 * 2/3 * 3 * {mensalidade:C2} =";
            labelCobrancaValor.Text = $@"{cobranca:C2}";

            labelReservaValor.Text = $@"{reserva:C2}";
            if (reserva < 0) {
                labelReservaValor.BackColor = Color.Red;
                labelReservaValor.ForeColor = Color.White;
            }
            else if (reserva < 0.1m * arrecadacao) {
                labelReservaValor.BackColor = Color.Yellow;
                labelReservaValor.ForeColor = Color.Black;
            }
            else {
                labelReservaValor.BackColor = labelTotalValor.BackColor;
                labelReservaValor.ForeColor = labelTotalValor.ForeColor;
            }
        }

        private void labelTomadas_DoubleClick(object sender, EventArgs e) {
            numericUpDownTomadas.Value = Database.Tomadas();
        }

        private void labelSalario_Click(object sender, EventArgs e) {
            numericUpDownSalario.Value = Database.VergilioGetLastPayment();
        }
    }
}

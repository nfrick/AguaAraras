using DataLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AguaAraras {
    public partial class frmCalculadora : Form {
        private decimal Fator;

        public frmCalculadora() {
            InitializeComponent();
        }

        private void frmCalculadora_Load(object sender, EventArgs e) {
            nupSalario.Value = GetLastManutencao();
            nupTomadas.Value = GetTomadas();
            labelAtual.Text = GetAtual().ToString("C2");
            CalcularMensalidade();
        }

        private void CalcularMensalidade_Changed(object sender, EventArgs e) {
            CalcularMensalidade();
        }

        private void CalcularDetalhes_Changed(object sender, EventArgs e) {
            CalcularDetalhes();
        }

        private void CalcularMensalidade() {
            Fator = 13 / ((10.8m * nupTomadas.Value - 8));
            var mensalidade = Fator * nupSalario.Value;
            labelCalculado.Text = $@"{mensalidade:C2}";
            nupMensalidade.Value = Math.Ceiling(mensalidade / 5) * 5;
            CalcularDetalhes();
        }

        private void CalcularDetalhes() {
            decimal mensalidade;

            if (radioButtonCalculado.Checked)
                mensalidade = Fator * nupSalario.Value;
            else if (radioButtonAtual.Checked)
                mensalidade = GetAtual();
            else {  // Usar valor calculado e arredondado para múltiplo de 5
                mensalidade = nupMensalidade.Value;
            }

            var arrecadacao = 12 * nupTomadas.Value * mensalidade;
            var vergilio = 13 * nupSalario.Value;
            var cobranca = 8 * mensalidade;
            var reserva = arrecadacao - (vergilio + cobranca);
            labelTotalDesc.Text = $@"12 * {nupTomadas.Value} * {mensalidade:C2} =";
            labelTotalValor.Text = $@"{arrecadacao:C2}";

            labelVergilioDesc.Text = $@"13 * {nupSalario.Value:C2} =";
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

        #region RESET DE VALORES NA TELA
        private void labelTomadas_DoubleClick(object sender, EventArgs e) {
            nupTomadas.Value = GetTomadas();
        }

        private void labelSalario_Click(object sender, EventArgs e) {
            nupSalario.Value = GetLastManutencao();
        }
        #endregion RESET DE VALORES NA TELA

        #region OBTER DADOS ATUAIS
        private decimal GetLastManutencao() {
            using (var ctx = new AguaArarasEntities()) {
                return Math.Abs(ctx.Movimentos.Where(m => m.Tipo == "manutenção")
                    .OrderByDescending(m => m.Data).FirstOrDefault()?.Valor ?? 0);
            }
        }

        private decimal GetTomadas() {
            using (var ctx = new AguaArarasEntities()) {
                return ctx.Pessoas.Where(p => p.Ativo)
                           .Sum(p => p.Tomadas);
            }
        }

        private decimal GetAtual() {
            using (var ctx = new AguaArarasEntities()) {
                return Math.Abs(ctx.Recibos
                .OrderByDescending(r => r.Vencimento).FirstOrDefault()?.Cota ?? 0);
            }
        }
        #endregion
    }
}
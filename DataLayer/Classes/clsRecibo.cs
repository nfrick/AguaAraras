using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DataLayer {
    public partial class Recibo {
        public int Ano => Emissao.Year;
        public string AnoNumero => $"{Ano:0000}-{Numero:0}";

        public string DescricaoShort => Numero > 5 ? $"Extra {Ano:0000}" :
            $@"{MonthNameShort(3 * (Numero - 1) + 1)}-{MonthNameShort(3 * (Numero - 1) + 2)}-{MonthNameShort(3 * (Numero - 1) + 3)}/{Ano:0000}";

        private string MonthName(int mes) {
            return CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(mes);
        }

        private string MesesLista() {
            var meses = new List<string>();
            for (int i = 1; i < 4; i++)
                meses.Add(MonthName(3 * (Numero - 1) + 1));
            return meses.ToConcatenatedString();
        }

        private string MonthNameShort(int mes) {
            return MonthName(mes).Substring(0, 3);
        }

        public decimal Total => Cotas.Sum(c => c.Valor);
        public decimal Recebido => Cotas.Where(c => c.Data != null).Sum(c => c.Valor);
        public decimal Pendente => Cotas.Where(c => c.Data == null).Sum(c => c.Valor);

        public string TotalAsString => Total.ToString("N2");
        public string RecebidoAsString => Recebido.ToString("N2");
        public string PendenteAsString => Pendente.ToString("N2");

        public void RecalcCotas() {
            foreach (var cota in Cotas) {
                cota.Valor = Math.Round(Meses * Cota * cota.Pessoa.Tomadas, 0);
            }
        }

        public Recibo(Recibo last, IEnumerable<Pessoa> ativos) {
            var hoje = DateTime.Today;
            if (last == null) {
                Numero = 1;
                Cota = 0;
            }
            else {
                Numero = (byte)(last.Numero == 4 ? 1 : last.Numero + 1);
                Cota = last.Cota;
            }
            Extra = false;
            Emissao = hoje;
            var Ano = hoje.Year;
            Vencimento = new DateTime(Ano, 3 * (Numero - 1) + 2, 10);
            Meses = 3;
            Descricao = Numero > 4 ? $"Extra {Ano}" : $"{MesesLista()} de {Ano}";
            Observacoes = string.Empty;
            Cotas = new ObservableListSource<Cota>();

            foreach (var p in ativos) {
                Cotas.Add(new Cota {
                    Pessoa = p,
                    Valor = Math.Round(p.Tomadas * Cota * Meses, 0)
                });
            }
        }
    }
}
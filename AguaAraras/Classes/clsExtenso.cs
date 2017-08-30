using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AguaAraras {
    class Extenso {
        private static readonly string[] Unidades = { "", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        private static readonly string[] Teens = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        private static readonly string[] Dezenas = { "", "", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        private static readonly string[] Centenas = { "", "cento", "duzentos", "trezentos", "quatrocentos", "quinhentos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        public static string Dinheiro(decimal numero) {
            var inteiro = (int)numero;
            var fracao = (int)(100 * (numero - (decimal)inteiro));

            var extensos = new List<string>();

            if (inteiro > 0)
                extensos.Add($"{NumeroPorExtenso(inteiro)} rea{(inteiro == 1 ? "l" : "is")}");
            if (fracao > 0)
                extensos.Add($"{NumeroPorExtenso(fracao)} centavo{(fracao == 1 ? "" : "s")}");
            return string.Join<string>(" e ", extensos);
        }

        public static string NumeroPorExtenso(int numero) {
            var milhao = numero / 1000000;
            var milhar = numero / 1000 - milhao * 1000;
            var centena = numero - (milhao * 1000000 + milhar * 1000);

            var extensos = new List<string>();

            if(milhao > 0)
                extensos.Add($"{PorExtenso(milhao)} milh{(milhao == 1 ? "ão" : "ões")}");
            if (milhar > 0)
                extensos.Add($"{PorExtenso(milhar)} mil");
            if (centena > 0)
                extensos.Add(PorExtenso(centena));

            return string.Join<string>(", ", extensos);
        }

        private static string PorExtenso(int numero) {
            var VC = numero / 100;
            var VD = numero / 10 - VC * 10;
            var VU = numero - (VC * 100 + VD * 10);

            var extensos = new List<string> {
                VC == 1 && VD == 0 && VU == 0 ? "cem" : Centenas[VC],
                VD == 1 ? Teens[VU] : Dezenas[VD]
            };

            if (VD != 1)
                extensos.Add(Unidades[VU]);
            return string.Join<string>(" e ", extensos.Where(e => e != string.Empty));
        }

        public static string ConcatenaLista(List<string> extensos) {
            var extenso = string.Join<string>(", ", extensos.Where(e => e != string.Empty));
            var pos = extenso.LastIndexOf(',');
            return pos == -1 ? 
                extenso : 
                extenso.Substring(0, pos) + " e" + extenso.Substring(pos + 1);
        }
    }
}

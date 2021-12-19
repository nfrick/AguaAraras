using System;

namespace DataLayer {
    public partial class Cota {
        // COTA
        public string ValorDescricao => $"{TomadasExtenso} x {ReciboCotaValor:C} x {ReciboMesesExtenso} = {Valor:C}"; //CotaValor * Tomadas * Meses);
        public string ValorExtenso => Extenso.Dinheiro(Valor);
        public override string ToString() {
            return $@"{Nome} - {ReciboNumeroAno}";
        }

        // PESSOA
        public byte Cobranca => Pessoa.Cobranca;
        public string Nome => Pessoa.Nome;
        public string Tratamento => Pessoa.Tratamento;
        public string Sobrenome => Pessoa.Sobrenome;
        public string NomeCompleto => $@"{Nome} {Sobrenome}";
        public string EMail => Pessoa.EMail;
        public byte Tomadas => Pessoa.Tomadas;
        public string TomadasExtenso => $@"{Tomadas} tomada{(Tomadas == 1 ? "" : "s")}";
        public string EnderecoAraras => Pessoa.EnderecoAraras;
        public bool GerarRecibo => Pessoa.Recibo;
        public string DepositoIdentificado => $@"Depósito identificado: {Valor + ((decimal)PessoaID) / 100:C}";

        // RECIBO
        public string ReciboAno => Recibo.Ano.ToString();
        public byte ReciboNumero => Recibo.Numero;
        public string ReciboNumeroAno => $@"{ReciboNumero:00}-{ReciboEmissao:yyyy}";
        public string ReciboAnoNumero => Recibo.AnoNumero;
        public DateTime ReciboEmissao => Recibo.Emissao;
        public DateTime ReciboVencimento => Recibo.Vencimento;
        public decimal ReciboCotaValor => Recibo.Cota;
        public byte ReciboMeses => Recibo.Meses;
        public string ReciboMesesExtenso {
            get {
                switch (ReciboMeses) {
                    case 0: return "";
                    case 1: return "1 mês";
                    default: return $@"{ReciboMeses} meses";
                }
            }
        }
        public string ReciboDescricao => Recibo.Descricao;
        public string ReciboObservacoes => Recibo.Observacoes;
    }
}
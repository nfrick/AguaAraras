using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class ReciboItem {
        public int ReciboID { get; set; }
        public byte ReciboNumero { get; set; }
        public string ReciboNumeroAno => $@"{ReciboNumero:00}-{Emissao:yyyy}";
        public DateTime Emissao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal CotaValor { get; set; }
        public byte Meses { get; set; }
        public string MesesExtenso {
            get {
                switch (Meses) {
                    case 0: return "";
                    case 1: return "1 mês";
                    default: return $@"{Meses} meses";
                }
            }
        }
        public string Descricao { get; set; }
        public string Observacoes { get; set; }
        public decimal Valor { get; set; }  // => CotaValor * Tomadas * Meses;
        public string ValorExtenso => Extenso.Dinheiro(Valor);

        public string ValorDescricao => $"{TomadasExtenso} x {CotaValor:C} x {MesesExtenso} = {Valor:C}"; //CotaValor * Tomadas * Meses);
        public int PessoaID { get; set; }
        public string Tratamento { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeCompleto => $@"{Nome} {Sobrenome}";
        public string EMail { get; set; }
        public byte Tomadas { get; set; }
        public string TomadasExtenso => $@"{Tomadas} tomada{(Tomadas == 1 ? "" : "s")}";
        public byte RuaAraras { get; set; }
        public string RuaArarasExtenso => RuaAraras == 1 ? "Mata Cavalo" : "Cascata";
        public string EnderecoAraras => $@"Estrada {RuaArarasExtenso} nº {EnderecoNumero}";
        public string EnderecoNumero { get; set; }
        public byte Cobranca { get; set; }
        public bool GerarRecibo { get; set; }
        public string DepositoIdentificado => $@"Depósito identificado: {Valor + ((decimal) PessoaID) / 100:C}";
        public override string ToString() {
            return $@"{Nome} - {ReciboNumeroAno}";
        }

        public ReciboItem(SqlDataReader r) {
            ReciboID = (int)r["ReciboID"];
            ReciboNumero = (byte)r["ReciboNumero"];
            Emissao = (DateTime)r["Emissao"];
            Vencimento = (DateTime)r["Vencimento"];
            CotaValor = (decimal)r["CotaValor"];
            Valor = (decimal)r["Valor"];
            Meses = (byte)r["Meses"];
            Descricao = r["Descricao"].ToString();
            Observacoes = r["Observacoes"].ToString();
            PessoaID = (int)r["PessoaID"];
            Tratamento = r["Tratamento"].ToString();
            Nome = r["Nome"].ToString();
            Sobrenome = r["Sobrenome"].ToString();
            EMail = r["EMail"].ToString();
            Tomadas = (byte)r["Tomadas"];
            RuaAraras = (byte)r["RuaAraras"];
            EnderecoNumero = r["EnderecoNumero"].ToString();
            Cobranca = (byte)r["Cobranca"];
            GerarRecibo = (bool)r["GerarRecibo"];
        }
    }
}

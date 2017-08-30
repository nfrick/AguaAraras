using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class Cota : BaseData {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public DateTime? Data { get; set; }
        public decimal Valor { get; set; }
        public string Observacoes { get; set; }
        public byte Cobranca { get; set; }
        
        public Cota(SqlDataReader r)
            : base(r) {
            PessoaID = (int)r["PessoaID"];
            Nome = r["Nome"].ToString();
            Data = (r["Data"] == DBNull.Value) ? (DateTime?)null : ((DateTime)r["Data"]);
            Valor = (decimal)r["Valor"];
            Observacoes = r["Observacoes"].ToString();
            Cobranca = (byte)r["Cobranca"];
        }
    }
}

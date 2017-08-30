using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public abstract class BaseMov : BaseData {
        public string Recibo { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public DateTime? Data { get; set; }
        public string Historico { get; set; }
        public decimal Valor { get; set; }

        protected BaseMov() {
            Recibo = string.Empty;
            Nome = string.Empty;
            Tipo = string.Empty;
            Data = null;
            Historico = string.Empty;
            Valor = 0m;
        }

        protected BaseMov(SqlDataReader r)
            : base(r) {
            Recibo = r["Recibo"].ToString();
            Nome = r["Nome"].ToString();
            Tipo = r["Tipo"].ToString();
            Data = r["Data"] == DBNull.Value ? (DateTime?)null : (DateTime)r["Data"];
            Historico = r["Historico"].ToString();
            Valor = (decimal)r["Valor"];
        }
    }
}

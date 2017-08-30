using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class Extrato {
        public int ID { get; set; }
        public string Tipo { get; set; }
        public DateTime? Data { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal Saldo { get; set; }

        public Extrato() {
            Saldo = 0m;
        }
        public Extrato(SqlDataReader r) {
            ID = (int)r["ID"];
            Tipo = r["Tipo"].ToString();
            Data = (r["Data"] == DBNull.Value) ? (DateTime?)null : ((DateTime)r["Data"]);
            Descricao = r["Descricao"].ToString();
            Valor = (decimal)r["Valor"];
            Saldo = (decimal)r["Saldo"];
        }
    }
}

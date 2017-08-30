using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class BalanceItem {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public int Centavos => (int)((Valor % 1) * 100);
        public string Nome { get; set; }

        /// <summary>
        /// Creates a BalanceItem from SQL Server database
        /// </summary>
        /// <param name="r"></param>
        public BalanceItem(SqlDataReader r) {
            Data = (DateTime)r["Data"];
            Valor = (decimal)r["Valor"];
            Nome = r["Nome"].ToString();
        }
    }
}

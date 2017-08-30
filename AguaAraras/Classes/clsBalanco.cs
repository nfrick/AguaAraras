using System.Data.SqlClient;

namespace AguaAraras {

    public class Balanco {
        public int Ano { get; set; }
        public int Periodo { get; set; }
        public decimal Positivo { get; set; }
        public decimal Negativo { get; set; }
        public decimal Saldo => Positivo + Negativo;

        public Balanco(SqlDataReader r) {
            Ano = (int)r["Ano"];
            Periodo = (int)r["Periodo"];
            Positivo = (decimal)r["Positivo"];
            Negativo = (decimal)r["Negativo"];
        }
    }
}

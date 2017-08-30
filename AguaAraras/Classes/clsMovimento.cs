using System.Data.SqlClient;

namespace AguaAraras {
    public class Movimento : BaseMov {
        public string Observacoes { get; set; }

        public Movimento() {
            Observacoes = string.Empty;
        }
        public Movimento(SqlDataReader r)
            : base(r) {
            Observacoes = r["Observacoes"].ToString();
        }
    }
}

using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class Telefone : BaseData {
        public int PessoaID { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public byte Tipo { get; set; }

        public Telefone() {
            PessoaID = 0;
            DDD = string.Empty;
            Numero = string.Empty;
            Tipo = 1;
        }

        public Telefone(SqlDataReader r)
            : base(r) {
            PessoaID = (int)r["PessoaID"];
            DDD = r["DDD"].ToString();
            Numero = r["Numero"].ToString();
            Tipo = (byte)r["Tipo"];
        }
    }
}

using System.Data.SqlClient;

namespace AguaAraras {
    public class Endereco : BaseData {
        public int PessoaID { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP {
            get => _cep == string.Empty ? string.Empty : _cep.Insert(2, ".").Insert(6, "-");
            set => _cep = value == string.Empty ? string.Empty : value.Remove(2, 1).Remove(5, 1);
        }
        public string uCEP => _cep;
        public bool Residencia { get; set; }
        public bool Correspondencia { get; set; }

        private string _cep;

        public Endereco() {
            PessoaID = 0;
            Logradouro = string.Empty;
            Bairro = string.Empty;
            Cidade = string.Empty;
            Estado = string.Empty;
            _cep = string.Empty;
            Residencia = false;
            Correspondencia = false;
        }

        public Endereco(SqlDataReader r)
            : base(r) {
            PessoaID = (int)r["PessoaID"];
            Logradouro = r["Logradouro"].ToString();
            Bairro = r["Bairro"].ToString();
            Cidade = r["Cidade"].ToString();
            Estado = r["Estado"].ToString();
            _cep = r["CEP"].ToString().Trim();
            Residencia = (bool)r["Residencia"];
            Correspondencia = (bool)r["Correspondencia"];
        }
    }
}

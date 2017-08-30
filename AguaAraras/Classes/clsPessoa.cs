using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class Pessoa : BaseData {
        public bool Ativo { get; set; }
        public string Tratamento { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; }
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public string NomeTratamento => $"Sr{Tratamento}. {NomeCompleto}";
        public string EMail { get; set; }
        public byte Tomadas { get; set; }
        public byte RuaAraras { get; set; }
        public string RuaArarasExtenso => RuaAraras == 1 ? "Mata Cavalo" : "Cascata";
        public string EnderecoAraras => $@"Estrada {RuaArarasExtenso} nº {Numero}";
        public string Numero { get; set; }
        public byte Cobranca { get; set; }
        public bool Recibo { get; set; }
        public bool Atualizar { get; set; }
        public string Observacoes { get; set; }

        public Pessoa(SqlDataReader r)
            : base(r) {
            Ativo = (bool)r["Ativo"];
            Tratamento = r["Tratamento"].ToString();
            Nome = r["Nome"].ToString();
            Sobrenome = r["Sobrenome"].ToString();
            EMail = r["EMail"].ToString();
            Tomadas = (byte)r["Tomadas"];
            RuaAraras = (byte)r["RuaAraras"];
            Numero = r["Numero"].ToString();
            Cobranca = (byte)r["Cobranca"];
            Recibo = (bool)r["Recibo"];
            Atualizar = (bool)r["Atualizar"];
            Observacoes = r["Observacoes"].ToString();
        }

        public override bool Equals(object obj) {
            var pessoa = obj as Pessoa;
            if (pessoa != null) {
                var other = pessoa;
                return this.Equals(other);
            }
            else
                throw new ArgumentException("Objeto não é instância da classe Pessoa");
        }

        public bool Equals(Pessoa other) {
            if (other == null)
                return false;
            return
                Ativo.Equals(other.Ativo) &&
                Tratamento.Equals(other.Tratamento) &&
                Nome.Equals(other.Nome) &&
                Sobrenome.Equals(other.Sobrenome) &&
                EMail.Equals(other.EMail) &&
                Tomadas.Equals(other.Tomadas) &&
                Cobranca.Equals(other.Cobranca) &&
                Recibo.Equals(other.Recibo) &&
                Atualizar.Equals(other.Atualizar) &&
                Observacoes.Equals(other.Observacoes);
        }

        public override int GetHashCode() {
            return Sobrenome.GetHashCode();
        }

        public static bool operator ==(Pessoa bi1, Pessoa bi2) {
            if (object.ReferenceEquals(bi1, bi2)) return true;
            if (object.ReferenceEquals(bi1, null)) return false;
            return !object.ReferenceEquals(bi2, null) && bi1.Equals(bi2);
        }

        public static bool operator !=(Pessoa bi1, Pessoa bi2) {
            if (object.ReferenceEquals(bi1, bi2)) return false;
            if (object.ReferenceEquals(bi1, null)) return true;
            if (object.ReferenceEquals(bi2, null)) return true;
            return !bi1.Equals(bi2);
        }
    }
}

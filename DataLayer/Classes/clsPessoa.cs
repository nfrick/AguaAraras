using System.Linq;

namespace DataLayer {
    public partial class Pessoa {
        public string NomeCompleto => $"{Nome} {Sobrenome}";
        public string NomeTratamento => $"Sr{Tratamento}. {NomeCompleto}";
        public string RuaArarasExtenso => RuaAraras == 1 ? "Estrada Mata Cavalo" : "Rua da Serra Negra";
        public string EnderecoAraras => $@"{RuaArarasExtenso} nº {Numero}";
        public decimal Pendente => Cotas.Where(c => c.Data == null).Sum(c => c.Valor);
        public string PendenteAsString => Pendente.ToString("N2");
        public IOrderedEnumerable<Cota> CotasDescending => cotasDescending();

        private IOrderedEnumerable<Cota> cotasDescending() {
            return Cotas.OrderByDescending(c => c.Data);
        }
    }
}

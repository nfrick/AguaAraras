namespace DataLayer {
    public partial class sp_Extrato_Result {

        public sp_Extrato_Result() {
            
        }

        public sp_Extrato_Result(sp_Extrato_Result item) {
            RID = item.RID;
            Data = item.Data;
            Valor = item.Valor;
            Descricao = item.Descricao;
            Tipo = item.Tipo;
            Saldo = item.Saldo;
        }
    }
}
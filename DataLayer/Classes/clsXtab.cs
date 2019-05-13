namespace DataLayer {
    public partial class sp_Xtab_Result {
        public decimal Saldo => Cota + Receita + Manutencao + Material + Despesa + Coleta;
    }
}

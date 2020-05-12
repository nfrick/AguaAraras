namespace DataLayer {
    public partial class XtabItem {
        public decimal Saldo => Cota + Receita + Manutencao + Material + Despesa + Coleta;
    }
}

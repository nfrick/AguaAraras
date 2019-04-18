using System;
using System.Data.SqlClient;

namespace AguaAraras {
    public class XTabData {

        public string Periodo { get; set; }
        public decimal Cota { get; set; }
        public decimal Manutencao { get; set; }
        public decimal Material { get; set; }
        public decimal MaoDeObra { get; set; }
        public decimal Coleta { get; set; }
        public decimal Despesa { get; set; }
        public decimal Receita { get; set; }
        public decimal Saldo => Cota + Manutencao + Material + MaoDeObra + Coleta + Despesa + Receita;

        public XTabData() {
            Periodo = string.Empty;
            Cota = 0m;
            Receita = 0m;
            Manutencao = 0m;
            Material = 0m;
            MaoDeObra = 0m;
            Coleta = 0m;
            Despesa = 0m;
        }
        
        public XTabData(SqlDataReader r) {
            Periodo = r["Periodo"].ToString();
            Cota = (decimal)r["cota"];
            Receita = (decimal)r["Receita"];
            Manutencao = (decimal)r["Manutencao"];
            Material = (decimal)r["Material"];
            MaoDeObra = (decimal)r["MaoDeObra"];
            Coleta = (decimal)r["Coleta"];
            Despesa = (decimal)r["Despesa"];
        }
    }
}
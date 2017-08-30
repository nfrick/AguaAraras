using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace AguaAraras {
    public class Recibo : BaseData, INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool _extra;
        private byte _numero;
        private DateTime _emissao;
        private DateTime _vencimento;
        private decimal _cota;
        private byte _meses;
        private string _descricao;
        private string _observacoes;

        public bool Extra { get => _extra; set => SetField(ref _extra, value); }
        public byte Numero { get => _numero; set => SetField(ref _numero, value); }
        public DateTime Emissao { get => _emissao; set => SetField(ref _emissao, value); }
        public DateTime Vencimento { get => _vencimento; set => SetField(ref _vencimento, value); }
        public decimal Cota { get => _cota; set => SetField(ref _cota, value); }
        public byte Meses { get => _meses; set => SetField(ref _meses, value); }
        public string Descricao { get => _descricao; set => SetField(ref _descricao, value); }
        public string Observacoes { get => _observacoes; set => SetField(ref _observacoes, value); }
        public int Ano => Emissao.Year;

        public Recibo() {
            var hoje = DateTime.Now;
            var last = Database.RecibosGetLast();
            if (last == null) {
                Numero = 1;
                Cota = 0;
            }
            else {
                Numero = (byte)(last.Numero == 4 ? 1 : last.Numero + 1);
                Cota = last.Cota;
            }
            Extra = false;
            Emissao = DateTime.Now;
            Vencimento = new DateTime(hoje.Year, 3 * (Numero - 1) + 2, 10);
            Meses = 3;
            Descricao =
                $@"{CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(3 * (Numero - 1) + 1)}, {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(3 * (Numero - 1) + 2)} e {CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(3 * (Numero - 1) + 3)} de {hoje.Year}";
            Observacoes = string.Empty;
        }

        public Recibo(SqlDataReader r)
            : base(r) {
            Extra = (bool)r["Extra"];
            Numero = (byte)r["Numero"];
            Emissao = (DateTime)r["Emissao"];
            Vencimento = (DateTime)r["Vencimento"];
            Cota = (decimal)r["Cota"];
            Meses = (byte)r["Meses"];
            Descricao = r["Descricao"].ToString();
            Observacoes = r["Observacoes"].ToString();
        }

        protected virtual void OnPropertyChanged(string propertyName) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value,
            [CallerMemberName] string propertyName = null) {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}

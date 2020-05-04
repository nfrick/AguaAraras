using System.ComponentModel;

namespace DataLayer {
    public partial class Movimento : INotifyPropertyChanged {

        public event PropertyChangedEventHandler PropertyChanged;

        public string ReciboAnoNumero => Recibo?.AnoNumero;
    }
}

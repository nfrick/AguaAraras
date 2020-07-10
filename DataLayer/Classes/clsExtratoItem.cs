using System;

namespace DataLayer {
    public partial class ExtratoItem : ICloneable {

        public ExtratoItem() {

        }

        public object Clone() {
            return new ExtratoItem {
                RID = this.RID,
                Data = this.Data,
                Valor = this.Valor,
                Descricao = this.Descricao,
                Tipo = this.Tipo,
                Saldo = this.Saldo
            };
        }
    }
}
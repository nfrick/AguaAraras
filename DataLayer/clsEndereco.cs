using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer {
    public partial class Endereco {
        public string CEPformatted {
            get => CEP == string.Empty ? string.Empty : CEP.Insert(2, ".").Insert(6, "-");
            set => CEP = value == string.Empty ? string.Empty : 
                (value.Length == 8 ? value : value.Remove(2, 1).Remove(5, 1));
        }
    }
}

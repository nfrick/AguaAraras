using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace Testes {
    class Program {
        static void Main(string[] args) {
            using (var ctx = new AguaArarasEntities()) {
                foreach (var p in ctx.Pessoas) {
                    Console.WriteLine(p.Nome);
                    foreach (var m in p.Movimentos) {
                        Console.WriteLine("\t{m.Data}");
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas_Interfaces
{
    internal class Aeronave: Veiculo
    {
        public override void Estacionar()
        {
            Console.WriteLine("Manobrando o veiculo");
        }
    }
}

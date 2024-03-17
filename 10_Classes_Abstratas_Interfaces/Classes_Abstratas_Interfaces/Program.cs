using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Abstratas_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Veiculo v = new Veiculo(); // por ser abstrata não consegue instanciar diretamente
            Veiculo v1 = new Automovel();
            v1.Estacionar();
            v1.mover();
            Console.ReadLine();
        }
    }
}

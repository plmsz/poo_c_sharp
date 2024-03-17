using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exemplo_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora c1 = new Calculadora(2.2, 3.5);
            c1.Soma();
            c1.Subtracao();
            c1.Produto();
            c1.Divisao();
            Calculadora c2 = new Calculadora(2, 0);
            c2.Divisao();
            Console.ReadLine();
        }
    }
}

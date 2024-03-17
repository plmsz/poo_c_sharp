using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Polimorfismo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica("Ana", "12345678901", "93148982", "ana@mail");
            pf.Informacoes();
            double impostos = pf.PagarImpostos(2800);
            Console.WriteLine(pf.Nome + " paga de imposto " + impostos);

            Console.WriteLine();
            PessoaJuridica pj = new PessoaJuridica("Cia", "12345670001", "23148982", "cia@mail");
            impostos = pj.PagarImpostos(20000);
            pj.Informacoes();
            Console.WriteLine(pj.RazaoSocial + " paga de imposto " + impostos);
            Console.WriteLine();
        }
    }
}


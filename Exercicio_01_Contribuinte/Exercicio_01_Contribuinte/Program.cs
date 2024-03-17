            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_Contribuinte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContribuinteIndividual c1 = new ContribuinteIndividual("Ana", 20, "34567890", 5000);
            ContribuinteEmpregado c2 = new ContribuinteEmpregado("Paulo", 17, "34567890", 700);
            Console.WriteLine("Nome  | Idade | Telefone  | Salário |  Contriubuição");

            Console.WriteLine($"{c1.Nome}  | {c1.Idade} | {c1.Telefone} | {c1.Salario} | {c1.ContribuirInss()}");
            Console.WriteLine($"{c2.Nome}  | {c2.Idade} | {c2.Telefone} | {c2.Salario} | {c2.ContribuirInss()}");

            Console.ReadKey();
        }
    }
}

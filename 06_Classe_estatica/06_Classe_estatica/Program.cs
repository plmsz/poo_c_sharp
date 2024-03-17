using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classe_estatica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Ana", 5, 6, 8, 9);
            Aluno a2 = new Aluno("Pedro", 7, 6, 6, 5);
            Console.WriteLine(a1.EAprovado());
            Console.WriteLine(a2.EAprovado());
            Console.ReadKey();
        }
    }
}

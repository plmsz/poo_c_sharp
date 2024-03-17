using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Heranca_construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica("Ana", "12345678901", "93148982", "ana@mail");
            pf.Informacoes();

            PessoaJuridica pj = new PessoaJuridica("Cia", "12345670001", "23148982", "cia@mail");
            pj.Informacoes();
        }
    }
}

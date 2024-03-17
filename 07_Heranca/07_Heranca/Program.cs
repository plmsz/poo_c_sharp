using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.Nome = "Ana";
            pf.Telefone = "112192910";
            pf.Email = "email@email";
            pf.PagarImpostos();
            pf.BuscarCpf();

            PessoaJuridica pj = new PessoaJuridica();
            pj.RazaoSocial = "Empresa Cia.";
            pj.Telefone = "112192910";
            pj.Email = "email@email";
            pj.Cnpj = "222222222";
            pj.PagarImpostos();
        }
    }
}

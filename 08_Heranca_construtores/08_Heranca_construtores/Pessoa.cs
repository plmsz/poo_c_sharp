using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Heranca_construtores
{
    internal class Pessoa
    {
        protected string email;
        protected string telefone;

        public Pessoa(string email, string telefone) {
            this.email = email;
            this.telefone = telefone;
        }

        public void PagarImpostos()
        {
            Console.WriteLine("Pagando impostos");
        }

        public void BuscarCpf()
        {
            Console.WriteLine("Buscando CPF");
        }

    }
}

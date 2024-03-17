using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Polimorfismo
{
    internal class Pessoa
    {
        protected string email;
        protected string telefone;

        public Pessoa(string email, string telefone)
        {
            this.email = email;
            this.telefone = telefone;
        }

        public virtual double PagarImpostos(double lucro)
        {
            return lucro;
        }

        public void BuscarCpf()
        {
            Console.WriteLine("Buscando CPF");
        }

    }
}

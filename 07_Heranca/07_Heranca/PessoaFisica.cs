using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heranca
{
    internal class PessoaFisica : Pessoa // herda membros publicas e protegidas
    {
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public void BuscarCpf()
        {
            Console.WriteLine("Buscando CPF");
        }
    }
}

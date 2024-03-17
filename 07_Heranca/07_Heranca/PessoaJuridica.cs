using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Heranca
{
    internal class PessoaJuridica: Pessoa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        public string Telefone { 
            get {  return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set {  email = value; }
        }

        public void BuscarPorCnpj()
        {
            Console.WriteLine("Buscando cnpj");
        }
    }
}

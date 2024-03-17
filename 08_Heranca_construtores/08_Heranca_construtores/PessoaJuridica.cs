using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Heranca_construtores
{
    internal class PessoaJuridica: Pessoa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

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

        public PessoaJuridica(string razaoSocial, string cnpj, string telefone, string email):base(telefone, email)
         {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
         }
        public void BuscarPorCnpj()
        {
            Console.WriteLine("Buscando cnpj");
        }

        public void Informacoes()
        {
            Console.WriteLine($"Nome: {RazaoSocial}");
            Console.WriteLine($"Cpf: {Cnpj}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
            Console.ReadKey();
        }
    }
}

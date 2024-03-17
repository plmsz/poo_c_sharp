using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Heranca_construtores
{
    internal class PessoaFisica: Pessoa
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

        public PessoaFisica(string nome, string cpf, string telefone, string email):base(telefone, email)
        {
            Cpf = cpf;
            Nome = nome;
        }

        public void BuscarCpf()
        {
            Console.WriteLine("Buscando CPF");
        }

        public void Informacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Cpf: {Cpf}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");

        }
    }
}

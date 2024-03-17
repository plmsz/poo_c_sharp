using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Polimorfismo
{
    internal class PessoaFisica:Pessoa
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
        //Ele busca o construtor da classe base, se não tiver personalizado, pega o padrão
        public PessoaFisica(string nome, string cpf, string telefone, string email) : base(telefone, email)
        {
            Cpf = cpf;
            Nome = nome;
        }

        public void BuscarCpf()
        {
            Console.WriteLine("Buscando CPF");
        }

        public override double PagarImpostos(double lucro)
        {
            return lucro * 0.1;
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

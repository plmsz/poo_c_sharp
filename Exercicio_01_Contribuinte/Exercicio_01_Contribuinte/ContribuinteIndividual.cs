using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_Contribuinte
{
    internal class ContribuinteIndividual : Contribuinte
    {
        private string nome;
        private int idade;
        private string telefone;
        private double salario;

        public string Nome
        {
            get { return nome; }
        }

        public int Idade
        {
            get { return idade; }
        }
        public string Telefone
        {
            get { return telefone; }
        }

        public ContribuinteIndividual(string nome, int idade, string telefone, double salario) : base(nome, idade, telefone, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.salario = salario;
        }

        public double Salario
        {
            get { return salario; }
        }

        public override double ContribuirInss()
        {

            if (salario < 788)
            {
                return salario * 0.05;
            }
            else if (salario >= 788 && salario < 4663.75)
            {
                return salario * 0.11;
            }
            else
            {
                return salario * 0.2;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_Contribuinte
{
    internal class ContribuinteEmpregado : Contribuinte
    {
        private string nome;
        private int idade;
        private string telefone;
        private double salario;

        public string Nome { get { return nome; } }
        public int Idade { get { return idade; } }
        public string Telefone { get { return telefone; } }
        public double Salario { get {  return salario; } }

        public ContribuinteEmpregado(string nome, int idade, string telefone, double salario) : base(nome, idade, telefone, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.salario = salario;
        }

        public override double ContribuirInss()
        {
            if (salario < 1399.12)
            {
            return salario * 0.08;
            }
            else if (salario >= 1399.12 && salario < 2331.88)
            {
                return salario * 0.09;
            }
            else
            {
                return salario * 0.11;
            }
        }
    }
}

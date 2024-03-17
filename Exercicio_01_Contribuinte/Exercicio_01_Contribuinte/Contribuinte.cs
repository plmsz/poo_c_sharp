using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01_Contribuinte
{
    internal abstract class Contribuinte
    {
        protected string nome;
        protected int idade;
        protected string telefone;
        protected double salario;

        protected Contribuinte(string nome, int idade, string telefone, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.salario = salario;
        }

        public abstract double ContribuirInss();
        
    }
}

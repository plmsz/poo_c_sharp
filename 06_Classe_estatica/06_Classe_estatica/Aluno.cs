using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Classe_estatica
{
    internal class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        public double Nota4 { get; set; }

        public static double MediaAprovacao = 7.0;

        public Aluno(string nome, double nota1, double nota2, double nota3, double nota4)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;
        }
        public double CalculaMedia()
        {
            return (Nota1 + Nota2 + Nota3 + Nota4) / 4;
        }

        public string EAprovado() {
         bool resultado = CalculaMedia() >= MediaAprovacao;
         return $"{Nome}: {CalculaMedia()}, {(resultado ? "Aprovado" : "Reprovado")}";
        }
    }
}

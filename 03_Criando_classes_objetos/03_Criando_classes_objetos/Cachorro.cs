using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Criando_classes_objetos
{
    internal class Cachorro
    {
        private string nome; //atributos geralmente são privados
        private int idade; //só é visivel dentro da classe
        public bool Castrado { get; set; } //auto-implemented property
        public string Nome
        {
            get { return nome != null ? nome : "vira-lata"; }
            set { nome = value; }
        }
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value < 0)
                {
                    idade = 0;
                }
                else
                {
                    idade = value;
                }
            }
        }

        public void Dormir() //geral metodos são publicos
        {
            Console.WriteLine(nome + "A mimir");
        }

        public void PegarBola()
        {
            Console.WriteLine("Pegou a Bola...");
        }

    }
}

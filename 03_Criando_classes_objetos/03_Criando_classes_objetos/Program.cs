using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Criando_classes_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Cachorro doguinho = new Cachorro();
            doguinho.Nome = "Floquinho";
            doguinho.Idade = 1;
            //doguinho.cor_pelo = "Verde"; // atributo privado

            Console.WriteLine("O cachorro " + doguinho.Nome);
            doguinho.PegarBola();

            Cachorro doguinho2 = new();
            //doguinho2.Nome = "Bidu";
            doguinho2.Idade = -5;

            Console.WriteLine("O cachorro " + doguinho2.Nome);
            Console.WriteLine($"{doguinho2.Nome} possui {doguinho2.Idade} anos");
            doguinho.Dormir();
            Console.ReadKey();
        }
    }
}

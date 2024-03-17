using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sobrcarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            string valor1Str = Console.ReadLine();

            Console.WriteLine("Digite o segundo valor:");
            string valor2Str = Console.ReadLine();

            // Validação de entrada
            int valor1Int, valor2Int;
            if (!int.TryParse(valor1Str, out valor1Int) || !int.TryParse(valor2Str, out valor2Int))
            {
                Console.WriteLine("Erro: valores inválidos!");
                return;
            }

            Calculadora calculadora1 = new Calculadora();
            int soma1 = calculadora1.Soma(10, 20);
            Console.WriteLine(soma1);

            int subtracao1 = calculadora1.Subtracao(valor1Int, valor2Int);
            Console.WriteLine("Subtração: " + subtracao1);

            // Soma de strings - sobrecarga por tipo
            Calculadora calculadora2 = new Calculadora();
            int soma2 = calculadora2.Soma(valor1Str, valor2Str);
            Console.WriteLine("Soma de strings: " + soma2);

            //Sobrecarga pelo numero de parametros
            int subtracao2 = calculadora2.Subtracao(valor1Int, valor1Int, 100);
            Console.WriteLine("Subtração: " + subtracao2);
        }
    }
}

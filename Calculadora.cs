using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Sobrcarga
{
    internal class Calculadora
    {
        // Soma com dois parâmetros do tipo int
        public int Soma(int num1, int num2)
        {
            return num1 + num2;
        }

        // Sobrecarga de Soma com dois parâmetros do tipo string
        public int Soma(string num1, string num2)
        {
            int valor1Int = int.Parse(num1);
            int valor2Int = int.Parse(num2);

            return valor1Int + valor2Int;
        }

        // Subtração com dois parâmetros do tipo int
        public int Subtracao(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Subtracao(int num1, int num2 , int num3)
        {

            return num1 - num2 - num3;
        }

    }
}

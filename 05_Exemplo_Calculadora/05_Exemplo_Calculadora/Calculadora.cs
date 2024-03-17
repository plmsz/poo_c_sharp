using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Exemplo_Calculadora
{
    internal class Calculadora
    {
        private double valor_1;
        private double valor_2;

        public Calculadora(double valor_1, double valor_2)
        {
            this.valor_1 = valor_1;
            this.valor_2 = valor_2;
        }
        public void Soma()
        {
            double resultado = valor_1 + valor_2;
            Console.WriteLine($"{valor_1} + {valor_2} = {resultado}");
        }
        public void Subtracao()
        {
            double resultado = valor_1 - valor_2;
            Console.WriteLine($"{valor_1} - {valor_2} = {resultado}");
        }
        public void Divisao()
        {
            if (valor_2 == 0)
            {
                Console.WriteLine("Não é possível a divisão");
            }
            else
            {
                double resultado = valor_1 / valor_2;
                Console.WriteLine($"{valor_1} / {valor_2} = {resultado}");
            }
        }
        public void Produto()
        {
            double resultado = valor_1 - valor_2;
            Console.WriteLine($"{valor_1} - {valor_2} = {resultado}");
        }
    }
}

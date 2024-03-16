using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_1_Criando_Classes
{
    internal class ContaBancaria
    {
        public string NomeCliente { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public void Deposita(double valorDepositado)
        {
            Saldo += valorDepositado;
        }

        public void Sacar(double valorSacado)
        {
            Saldo -= valorSacado;
        }

        public void VisualizarSaldo()
        {
            Console.WriteLine(Saldo);
        }
    }

}

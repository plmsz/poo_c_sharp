using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Construtores
{
    internal class ContaBancaria
    {
        public string NomeCliente { get; set; }
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(string nomeCliente, int numero, double saldo)
        {
            NomeCliente = nomeCliente;
            Numero = numero;
            Saldo = saldo;
        }

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
            Console.WriteLine($"Nome: {NomeCliente}, Conta: {Numero}, \nSaldo: {Saldo}");
        }

    }
}

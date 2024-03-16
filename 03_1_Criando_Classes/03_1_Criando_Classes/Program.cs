namespace _03_1_Criando_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria();
            c1.NomeCliente = "Chica da Silva";
            c1.Numero = 0001;
            c1.Saldo = 0;
            c1.Deposita(200);
            c1.VisualizarSaldo();
            c1.Sacar(80);
            c1.VisualizarSaldo();
        }
    }
}
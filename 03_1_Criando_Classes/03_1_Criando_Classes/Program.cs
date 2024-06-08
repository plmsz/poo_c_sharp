namespace _03_1_Criando_Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 2.12342;
            double b = 2.12345;
            double c = 2.12346;
            double d = 2.122;
            double e = 2.128;

            Console.WriteLine(Math.Round(a, 4));
            Console.WriteLine(Math.Round(b, 4));
            Console.WriteLine(Math.Round(c, 4));
            Console.WriteLine(Math.Round(d, 4));
            Console.WriteLine(Math.Round(e, 4));
            Console.ReadKey();

            /*ContaBancaria c1 = new ContaBancaria();
            c1.NomeCliente = "Chica da Silva";
            c1.Numero = 0001;
            c1.Saldo = 0;
            c1.Deposita(200);
            c1.VisualizarSaldo();
            c1.Sacar(80);
            c1.VisualizarSaldo();*/
        }
    }
}
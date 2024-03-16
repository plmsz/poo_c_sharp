namespace _04_Construtores {
	class Program
	{
        static void Main(string[] args)
        {
            ContaBancaria c1 = new ContaBancaria("Chica da Silva", 199, 0);
            c1.Deposita(200);
            c1.VisualizarSaldo();
            c1.Sacar(80);
            c1.VisualizarSaldo();

            ContaBancaria c2 = new ContaBancaria();
            c2.NomeCliente = "Chico de Assis";
            c2.Numero = 1;
            c2.VisualizarSaldo();
        }
    }
}

namespace Metodos_Parciais;

public partial class RitualMagico
{
    public string Nome { get; set; }

    public RitualMagico(string nome)
    {
        Nome = nome;
    }

    private partial void PrepararRitual();

    public void ExecutarRitual()
    {
        PrepararRitual();
        Console.WriteLine("O ritual {0} está sendo executado.", Nome);
    }
}
# Herança:

A herança em C# permite que uma classe (derivada) herde características de outra (base), como atributos, métodos e construtores.

# Modificador protected:
O modificador protected permite que membros da classe (atributos e métodos) sejam acessíveis apenas pela classe base e pelas classes derivadas. Isso encapsula dados e garante a consistência da implementação, promovendo a segurança e a confiabilidade do código.

```c#
public class Mago
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; set; }
    public List<string> MagiasAprendidas { get; set; }

    public Mago(string nome, string especialidade)
    {
        Nome = nome;
        NivelMana = 100;
        Especialidade = especialidade;
        MagiasAprendidas = new List<string>();
    }

    public void LancarFeitico(string nomeFeitico)
    {
        Console.WriteLine($"{Nome} lançou o feitiço {nomeFeitico}!");
    }

    public void AdicionarMagiaAprendida(string nomeFeitico)
    {
        MagiasAprendidas.Add(nomeFeitico);
    }
}

```
```c#
public class MagoDeFogo : Mago
{
    public MagoDeFogo(string nome) : base(nome, "Fogo")
    {
        AdicionarMagiaAprendida("Bola de Fogo");
    }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Bola de Fogo")
        {
            Console.WriteLine($"{Nome} lançou o feitiço Bola de Fogo com fúria ardente!");
        }
        else
        {
            base.LancarFeitico(nomeFeitico);
        }
    }
}

```
```c#
public class MagoDeGelo : Mago
{
    public MagoDeGelo(string nome) : base(nome, "Gelo")
    {
        AdicionarMagiaAprendida("Estaca de Gelo");
    }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Estaca de Gelo")
        {
            Console.WriteLine($"{Nome} lançou o feitiço Estaca de Gelo com poder congelante!");
        }
        else
        {
            base.LancarFeitico(nomeFeitico);
        }
    }
}

```
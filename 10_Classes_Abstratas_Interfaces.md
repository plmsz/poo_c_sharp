# Classes abstratas:

São classes que não podem ser instanciadas diretamente.
Servem como modelos para classes derivadas.
Definem características e comportamentos comuns a um grupo de classes.
Permitem o reuso de código e a organização do código em uma hierarquia.
## Características:

Possuem o modificador abstract.
Podem conter métodos abstratos e concretos.
Métodos abstratos não possuem implementação e são obrigatoriamente implementados nas classes derivadas.
Classes derivadas de classes abstratas podem ser abstratas ou concretas.

# Métodos abstratos:
São métodos declarados em classes abstratas sem implementação.
Possuem o modificador abstract.
Definem o nome, parâmetros e tipo de retorno do método.
A implementação é fornecida obrigatoriamente nas classes derivadas.


```c#
public abstract class EntidadeMagica
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; protected set; }

    public EntidadeMagica(string nome, string especialidade)
    {
        Nome = nome;
        NivelMana = 100;
        Especialidade = especialidade;
    }

    public abstract void LancarFeitico(string nomeFeitico);

    public virtual void Meditar()
    {
        NivelMana += 10;
        Console.WriteLine($"{Nome} meditou e restaurou sua mana!");
    }

    public void Descansar()
    {
        Console.WriteLine($"{Nome} está descansando...");
    }

    public abstract void FalarMagia();
}

public class Mago : EntidadeMagica
{
    public Mago(string nome) : base(nome, "Magia") { }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Bola de Fogo")
            Console.WriteLine($"{Nome} lançou Bola de Fogo com fúria ardente!");
        else
            base.LancarFeitico(nomeFeitico);
    }

    public override void FalarMagia()
    {
        Console.WriteLine($"{Nome} recita palavras mágicas misteriosas!");
    }
}

public class Feiticeira : EntidadeMagica
{
    public Feiticeira(string nome) : base(nome, "Feitiçaria") { }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Encantamento")
            Console.WriteLine($"{Nome} lançou um Encantamento poderoso!");
        else
            base.LancarFeitico(nomeFeitico);
    }

    public override void FalarMagia()
    {
        Console.WriteLine($"{Nome} canta uma melodia mágica encantadora!");
    }
}

var mago = new Mago("Mago Supremo");
mago.LancarFeitico("Bola de Fogo");
mago.Meditar();
mago.FalarMagia();

var feiticeira = new Feiticeira("Feiticeira Encantadora");
feiticeira.LancarFeitico("Encantamento");
feiticeira.Descansar();
feiticeira.FalarMagia();

```
# Interfaces:
São contratos que definem um conjunto de métodos e propriedades que uma classe deve obrigatoriamente implementar.
Permitem o desacoplamento entre classes e aumentam a flexibilidade do código.
As classes podem implementar uma ou mais interfaces.
Interfaces não podem ser instanciadas.

```c#
public interface ICompositor
{
    void ComporMusica(string estiloMusical);
    string TituloMusica { get; }
}

public interface IInstrumentista
{
    void TocarInstrumento(string instrumento);
    string InstrumentoPrincipal { get; }
}

public abstract class EntidadeMagica
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; protected set; }

    public EntidadeMagica(string nome, string especialidade)
    {
        Nome = nome;
        NivelMana = 100;
        Especialidade = especialidade;
    }

    public abstract void LancarFeitico(string nomeFeitico);
}

class BardoMágico : EntidadeMágica, ICompositor, IInstrumentista
{
    public string InstrumentoPrincipal { get; set; } = "Flauta Mágica";

    public BardoMágico(string nome) : base(nome, "Magia Musical")
    {
        NivelMana = 150;
    }

    public void ComporMusica(string estiloMusical)
    {
        Console.WriteLine($"{Nome} compôs a Balada Mágica com {estiloMusical}!");
    }

    public void TocarInstrumento()
    {
        Console.WriteLine($"{Nome} toca o Alaúde Mágico com melodias mágicas!");
    }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Melodia Encantadora")
            Console.WriteLine($"{Nome} lançou a Melodia Encantadora, enfeitiçando o público!");
        else
            base.LancarFeitico(nomeFeitico);
    }
}

class FlautistaTalentosa : ICompositor, IInstrumentista
{
    public string Nome { get; set; }
    public string InstrumentoPrincipal { get; set; } = "Flauta Transversal";

    public FlautistaTalentosa(string nome)
    {
        Nome = nome;
    }

    public void ComporMusica(string estiloMusical)
    {
        Console.WriteLine($"{Nome} compôs a Serenata da Floresta com {estiloMusical}!");
    }

    public void TocarInstrumento()
    {
        Console.WriteLine($"{Nome} toca a Flauta Transversal com melodias vibrantes!");
    }
}


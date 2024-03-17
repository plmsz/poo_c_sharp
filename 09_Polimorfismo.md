# Polimorfismo

O polimorfismo em C# é um conceito fundamental que permite que diferentes objetos respondam ao mesmo método de maneira específica e individualizada, proporcionando maior flexibilidade e versatilidade ao código.

## Polimorfismo de Sobrecarga:

Permite que uma classe defina o mesmo método com diferentes assinaturas (parâmetros), possibilitando a execução de ações específicas de acordo com os argumentos passados.

## Polimorfismo de Sobrescrita:

Permite que uma classe derivada substitua a implementação de um método herdado da classe base, customizando o comportamento de acordo com as necessidades da classe derivada.

```c#
public abstract class Mago
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; protected set; }

    public Mago(string nome, string especialidade)
    {
        Nome = nome;
        NivelMana = 100;
        Especialidade = especialidade;
    }

    public virtual void LancarFeitico(string nomeFeitico)
    {
        Console.WriteLine($"{Nome} lançou o feitiço {nomeFeitico}!");
    }

    public virtual Criatura ConvocarCriatura()
    {
        throw new NotImplementedException("Invocação de criatura não implementada na especialidade base.");
    }
}

public class MagoDeFogo : Mago
{
    public MagoDeFogo(string nome) : base(nome, "Fogo") { }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Bola de Fogo")
            Console.WriteLine($"{Nome} lançou Bola de Fogo com fúria ardente!");
        else
            base.LancarFeitico(nomeFeitico);
    }

    // Sobrescrevendo o método para invocar uma criatura específica
    public override Criatura ConvocarCriatura()
    {
        Console.WriteLine($"{Nome} convocou um Salamander!");
        return new Salamander(); // Retorna uma instância da criatura específica
    }
}

public class MagoDeGelo : Mago
{
    public MagoDeGelo(string nome) : base(nome, "Gelo") { }

    public override void LancarFeitico(string nomeFeitico)
    {
        if (nomeFeitico == "Estaca de Gelo")
            Console.WriteLine($"{Nome} lançou Estaca de Gelo com poder congelante!");
        else
            base.LancarFeitico(nomeFeitico);
    }

    // Sobrescrevendo o método para invocar uma criatura específica
    public override Criatura ConvocarCriatura()
    {
        Console.WriteLine($"{Nome} convocou um Elemental de Gelo!");
        return new ElementalDeGelo(); // Retorna uma instância da criatura específica
    }
}

public class Criatura
{
    public virtual void Atacar()
    {
        Console.WriteLine("A criatura ataca!");
    }
}

public class Salamander : Criatura
{
    public override void Atacar()
    {
        Console.WriteLine("O Salamander cospe fogo!");
    }
}

public class ElementalDeGelo : Criatura
{
    public override void Atacar()
    {
        Console.WriteLine("O Elemental de Gelo congela o oponente!");
    }
}

var magoFogo = new MagoDeFogo("Mago Fogo");
var criaturaFogo = magoFogo.ConvocarCriatura();
criaturaFogo.Atacar(); // Ativa o ataque do Salamander

var magoGelo = new MagoDeGelo("Mago Gelo");
var criaturaGelo = magoGelo.ConvocarCriatura();
criaturaGelo.Atacar(); // Ativa o ataque do ElementalDeGelo


```

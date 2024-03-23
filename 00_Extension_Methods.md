# Extension Methods 
No C# nada mais são do que classes estáticas que podem viver fora das suas classes e ainda assim adicionar funcionalidade a mesma.

```C#
public static class MagiaExtensions
{
    public static void EncantarComFogo(this Magia magia)
    {
        // Adiciona o efeito de fogo à magia
        Console.WriteLine($"{magia.Nome} agora causa dano de fogo!");
    }

    public static void EncantarComInvisibilidade(this Magia magia)
    {
        // Adiciona o efeito de invisibilidade à magia
        Console.WriteLine($"{magia.Nome} agora torna o mago invisível!");
    }
}

public class Magia
{
    public string Nome { get; set; }

    public Magia(string nome)
    {
        Nome = nome;
    }

    public void LancarMagia()
    {
        Console.WriteLine($"{Nome} foi lançada!");
    }
}

public class Mago
{
    public string Nome { get; set; }
    public List<Magia> Magias { get; set; }

    public Mago(string nome)
    {
        Nome = nome;
        Magias = new List<Magia>();
    }

    public void LancarMagia(string nomeMagia)
    {
        Magia magia = Magias.Find(m => m.Nome == nomeMagia);
        magia.LancarMagia();

        // Encanta a magia com fogo
        magia.EncantarComFogo();

        // Encanta a magia com invisibilidade
        magia.EncantarComInvisibilidade();
    }
}
```
Conversão de um tipo de objeto para outro
Imagine um mago que possui um cajado mágico poderoso com diversas propriedades, como a capacidade de lançar feitiços poderosos e armazenar mana. O mago precisa converter o cajado em uma varinha mais leve e portátil para realizar feitiços mais precisos em um contexto específico.
```c#
public class Cajado
{
    public string Nome { get; set; }
    public int Poder { get; set; }
    public int ArmazenamentoMana { get; set; }
    public bool PodeVoar { get; set; }

    public Cajado(string nome, int poder, int armazenamentoMana, bool podeVoar)
    {
        Nome = nome;
        Poder = poder;
        ArmazenamentoMana = armazenamentoMana;
        PodeVoar = podeVoar;
    }
}

public static class CajadoExtensions
{
    public static Varinha ConverterParaVarinha(this Cajado cajado)
    {
        // Converte o cajado em uma varinha, ignorando propriedades irrelevantes
        return new Varinha(cajado.Nome, cajado.Poder / 2);
    }
}

public class Varinha
{
    public string Nome { get; set; }
    public int Precisao { get; set; }

    public Varinha(string nome, int precisao)
    {
        Nome = nome;
        Precisao = precisao;
    }
}

public class Mago
{
    public string Nome { get; set; }
    public List<ObjetoMagico> ObjetosMagicos { get; set; }

    public Mago(string nome)
    {
        Nome = nome;
        ObjetosMagicos = new List<ObjetoMagico>();
    }

    public void ConverterCajadoParaVarinha(Cajado cajado)
    {
        Varinha varinha = cajado.ConverterParaVarinha();
        ObjetosMagicos.Add(varinha);

        Console.WriteLine($"{Nome} converteu o cajado {cajado.Nome} em uma varinha mais precisa para realizar feitiços específicos.");
    }
}
```
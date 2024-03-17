# Construtores:
Métodos especiais chamados ao criar um novo objeto.
Inicializam os atributos do objeto e realizam outras tarefas de configuração.
# Sobrecarga de Construtores:
Permite ter mais de um construtor em uma classe.
Cada construtor possui diferentes parâmetros.


# Exemplo:
```c#
public class Mago
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; set; }

    // Construtor sem parâmetros
    public Mago()
    {
        Nome = "Mago Anônimo";
        NivelMana = 50;
        Especialidade = "Magia Geral";
    }

    // Construtor com parâmetros "nome" e "especialidade"
    public Mago(string nome, string especialidade)
    {
        Nome = nome;
        NivelMana = 100;
        Especialidade = especialidade;
    }

    // Construtor com parâmetros "nome", "nivelMana" e "especialidade"
    public Mago(string nome, int nivelMana, string especialidade)
    {
        Nome = nome;
        NivelMana = nivelMana;
        Especialidade = especialidade;
    }

    // ... (outros métodos)
}
```

# Sobrecarga de Métodos:
 Permite que uma classe defina múltiplos métodos com o mesmo nome, mas com diferentes quantidade e tipos de parâmetros.
 ## Limitações da Sobrecarga de Método: 
 Ordem dos Parâmetros: A ordem dos parâmetros é crucial para identificar a versão correta do método.
 Ambiguidade: Evite sobrecargas que possam gerar ambiguidade e dificultar a escolha da versão correta do método.
```C#
public class Mago
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; set; }

    // Lançar Feitiço com parâmetro "tipoFeitico" (string)
    public void LancarFeitico(string tipoFeitico)
    {
        Console.WriteLine($"{Nome} lança um feitiço {tipoFeitico}!");
    }

    // Lançar Feitiço com parâmetros "tipoFeitico" (string) e "nivelPoder" (int)
    public void LancarFeitico(string tipoFeitico, int nivelPoder)
    {
        Console.WriteLine($"{Nome} lança um feitiço {tipoFeitico} com poder {nivelPoder}!");
        if (nivelPoder > 50)
        {
            Console.WriteLine("**Feitiço de alto poder!**");
        }
    }

    // Lançar Feitiço com parâmetro "alvo" (string)
    public void LancarFeitico(string tipoFeitico, string alvo)
    {
        Console.WriteLine($"{Nome} lança um feitiço {tipoFeitico} em {alvo}!");
    }

    // ... (outros métodos)
}

```

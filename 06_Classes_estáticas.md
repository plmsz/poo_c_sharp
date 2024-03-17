# static
- Classes estáticas não podem ser instanciadas.
- Membros estáticos não podem ser modificados por métodos não estáticos da mesma classe.
- O uso excessivo de classes e membros estáticos pode dificultar a modularização e o reuso de código.

# Casos de uso:
- conexão com banco de dados
- constante globais
- atributo/metdo possuir apenas um estado
## Exemplo:

```c#
public class Mago
{
    public string Nome { get; set; }
    public int NivelMana { get; set; }
    public string Especialidade { get; set; }

    // Atributo estático: Armazena o número total de magos criados
    public static int NumeroMagoCriados { get; private set; }

    // Construtor
    public Mago(string nome, string especialidade)
    {
        Nome = nome;
        NivelMana = 100;
        Especialidade = especialidade;
        NumeroMagoCriados++;
    }

    // Método estático: Retorna a saudação padrão para magos
    public static string ObterSaudacao()
    {
        return "Que a magia esteja com você!";
    }

    // ... (outros métodos)
}

// Cria dois magos
var magoFogo = new Mago("Mago Fogo", "Fogo");
var magoGelo = new Mago("Mago Gelo", "Gelo");

// Acessa o atributo estático
Console.WriteLine($"Número de magos criados: {Mago.NumeroMagoCriados}");

// Chama o método estático
Console.WriteLine(Mago.ObterSaudacao());
```

## Exemplo 2:
- A classe LivroDeMagias é declarada como static, indicando que é uma classe estática.
- A classe possui um dicionário estático _feiticos que armazena o nome de cada feitiço como chave e sua descrição como valor.
- A classe possui um método estático ObterDescricaoFeitico que recebe o nome de um feitiço como parâmetro e retorna sua descrição.
```c#
public static class LivroDeMagias
{
    // Dicionário que armazena feitiços e suas descrições
    private static readonly Dictionary<string, string> _feiticos = new Dictionary<string, string>()
    {
        { "Bola de Fogo", "Lança uma bola de fogo que causa dano em área." },
        { "Estaca de Gelo", "Cria uma estaca de gelo que congela o alvo." },
        { "Cura", "Restaura a saúde do alvo." },
        { "Escudo Mágico", "Cria um escudo mágico que protege o alvo de danos." }
    };

    // Método estático que retorna a descrição de um feitiço
    public static string ObterDescricaoFeitico(string nomeFeitico)
    {
        if (_feiticos.TryGetValue(nomeFeitico, out string descricao))
        {
            return descricao;
        }
        else
        {
            return "Feitiço não encontrado.";
        }
    }

    // ... (métodos estáticos para adicionar, remover e modificar feitiços)
}

 string descricaoFeitico = LivroDaMagia.ObterDescricaoFeitico("Cura");
 Console.Write(descricaoFeitico);
```
# Indexers
Permitem que você acesse membros de uma classe usando uma sintaxe semelhante à de um array ou dicionário. Isso torna o código mais intuitivo e facilita o acesso a dados de forma dinâmica.
Exemplo na Classe Feitiços:

```C#
public class Feiticos
{
    private readonly Dictionary<string, string> _feiticos = new Dictionary<string, string>()
    {
        { "Bola de Fogo", "Lança uma bola de fogo que causa dano em área." },
        { "Estaca de Gelo", "Cria uma estaca de gelo que congela o alvo." },
        { "Cura", "Restaura a saúde do alvo." },
        { "Escudo Mágico", "Cria um escudo mágico que protege o alvo de danos." }
    };

    // Indexador que retorna a descrição de um feitiço
    public string this[string nomeFeitico]
    {
        get
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
    }

    // ... (métodos para adicionar, remover e modificar feitiços)
}
var livroDeMagias = new Feiticos();

// Acessa a descrição de um feitiço usando a sintaxe de array
var descricaoBolaFogo = livroDeMagias["Bola de Fogo"];
Console.WriteLine(descricaoBolaFogo);

// Acessa a descrição de outro feitiço
var descricaoEstacaGelo = livroDeMagias["Estaca de Gelo"];
Console.WriteLine(descricaoEstacaGelo);
```
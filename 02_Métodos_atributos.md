# Atributos:

Os atributos, também conhecidos como propriedades, definem as características dos objetos da classe. No contexto da classe Mago, podemos ter:

- Nome: Define o nome do mago.
- NivelMana: Indica a quantidade de mana disponível para lançar feitiços.
- Especialidade: Especifica a área de expertise do mago, como fogo, gelo, necromancia, etc.
# Métodos:

Os métodos definem as ações que os objetos da classe podem realizar. Na classe Mago, podemos ter:

- LancarFeitico: Permite que o mago lance um feitiço, recebendo o tipo de feitiço como parâmetro.
- ConvocarCriatura: Permite que o mago convoque uma criatura mágica, recebendo o tipo de criatura como parâmetro.
- PrepararPocao: Permite que o mago prepare uma poção mágica, recebendo o tipo de poção como parâmetro.
Detalhes dos Métodos:

## LancarFeitico:

- Tipo de Retorno: void (não retorna valor).
- Parâmetros:
tipoFeitico (string): Tipo de feitiço a ser lançado (Bola de Fogo, Estaca de Gelo, etc.).
- Comportamento:
Imprime uma mensagem informando que o mago lançou o feitiço especificado.
Nas subclasses, pode verificar o tipo de feitiço e realizar ações específicas (como lançar Bola de Fogo ou Estaca de Gelo).
Caso não haja implementação específica na subclasse, utiliza a implementação da classe base (lançar um feitiço genérico).
## ConvocarCriatura:

- Tipo de Retorno: void (não retorna valor).
- Parâmetros:
tipoCriatura (string): Tipo de criatura a ser convocada (Elemental de Fogo, Golem de Gelo, etc.).
- Comportamento:
Imprime uma mensagem informando que o mago convocou a criatura especificada.
Pode ser implementado de forma específica em subclasses para considerar diferentes tipos de criaturas.
## PrepararPocao:

- Tipo de Retorno: void (não retorna valor).
- Parâmetros:
tipoPocao (string): Tipo de poção a ser preparada (Poção de Cura, Poção de Mana, etc.).
- Comportamento:
Imprime uma mensagem informando que o mago preparou a poção especificada.
Pode ser implementado de forma específica em subclasses para considerar diferentes tipos de poções e seus efeitos.

```c#
public class Mago
    {
        // Atributos
        public string Nome { get; set; }
        public int NivelMana { get; set; }
        public string Especialidade { get; set; }

        // Métodos
        public void LancarFeitico(string tipoFeitico)
        {
            Console.WriteLine($"{Nome} lança um feitiço {tipoFeitico}!");
        }

        public void ConvocarCriatura(string tipoCriatura)
        {
            Console.WriteLine($"{Nome} convoca uma criatura {tipoCriatura}!");
        }

        public void PrepararPocao(string tipoPocao)
        {
            Console.WriteLine($"{Nome} prepara uma poção {tipoPocao}!");
        }
    }
```
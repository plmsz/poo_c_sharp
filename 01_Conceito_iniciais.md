# Abstração:
Abstração é o processo de identificar as características essenciais de um objeto e ignorar os detalhes menos importantes. Em outras palavras, é a capacidade de representar conceitos do mundo real no software.
## Elementos-chave da abstração:
Classes: Representam entidades abstratas que reúnem características e comportamentos relacionados.
Atributos: Descrevem as propriedades das classes, como nome, idade e tipo de dado.
Métodos: Definem as ações que as classes podem realizar, como calcular, armazenar e recuperar informações.
## Exemplo:
A classe "Mago" pode ser definida com os seguintes atributos: nome, nível de mana e especialidade (necromancia, ilusionismo, etc.). Seus métodos podem incluir lançar feitiços, conjurar criaturas e preparar poções.

# Encapsulamento:
É o conceito de esconder os detalhes de implementação de um objeto e fornecer uma interface clara para interagir com ele.
Isso implica em reunir os dados (atributos) e os métodos (comportamentos) relacionados em uma única unidade, chamada classe. E então, controlar o acesso a esses dados e métodos através de modificadores de acesso.
## Mecanismos de encapsulamento:
Modificadores de acesso: Controlam o nível de acesso aos atributos e métodos das classes, definindo-os como públicos, privados ou protegidos.
- Public: Permite acesso irrestrito de qualquer parte do código.
- Private: Restringe o acesso à classe em que o membro foi definido.
Protected: Permite acesso à classe e suas subclasses.
## Exemplo:
Em uma classe de carro, podemos encapsular os detalhes do motor, como tipo, potência, etc., e fornecer métodos públicos para ligar, desligar o motor, etc., ocultando os detalhes de implementação do motor.
Herança:

# Herança 
é um conceito que permite que uma classe herde atributos e métodos de outra classe. A classe que herda é chamada de subclasse ou classe filha, e a classe da qual ela herda é chamada de superclasse ou classe pai.
Isso promove a reutilização de código e ajuda a organizar classes em uma hierarquia.
## Exemplo:
A classe "Mago de Fogo" pode herdar da classe "Mago" características como nome, nível de mana e métodos básicos (lançar feitiços, conjurar criaturas). Ela pode então adicionar métodos específicos, como "conjurarBolaDeFogo" e "lançarRajadaDeFogo".

# Polimorfismo 
significa "muitas formas" e refere-se à capacidade de um objeto ser tratado de várias maneiras diferentes.
## Formas de polimorfismo:
- Sobrecarga de métodos: Permite que métodos com o mesmo nome tenham diferentes comportamentos, de acordo com os tipos de parâmetros recebidos.
- Sobrescrita de métodos: Permite que subclasses redefinam o comportamento de métodos herdados da classe pai, adaptando-os às suas necessidades específicas.
## Exemplo:
A classe "Mago" pode ter um método "lançarFeitiço" que recebe o tipo de feitiço como parâmetro. Subclasses como "Mago de Fogo" e "Mago de Gelo" podem sobrescrever este método para implementar seus próprios tipos de feitiços.

# Exemplo em código: 

```c#
public class Mago
    {
        // Atributos
        public string Nome { get; set; }
        public int NivelMana { get; set; }
        public string Especialidade { get; set; }

        // Métodos
        public virtual void LancarFeitico(string tipoFeitico)
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

public class MagoDeFogo : Mago
{
    public MagoDeFogo(string nome, int nivelMana)
    {
        Nome = nome;
        NivelMana = nivelMana;
        Especialidade = "Fogo";
    }

    public override void LancarFeitico(string tipoFeitico)
    {
        if (tipoFeitico == "Bola de Fogo")
        {
            Console.WriteLine($"{Nome} lança uma bola de fogo!");
        }
        else
        {
            base.LancarFeitico(tipoFeitico);
        }
    }
}

public class MagoDeGelo : Mago
{
    public MagoDeGelo(string nome, int nivelMana)
    {
        Nome = nome;
        NivelMana = nivelMana;
        Especialidade = "Gelo";
    }

    public override void LancarFeitico(string tipoFeitico)
    {
        if (tipoFeitico == "Estaca de Gelo")
        {
            Console.WriteLine($"{Nome} lança uma estaca de gelo!");
        }
        else
        {
            base.LancarFeitico(tipoFeitico);
        }
    }
}
```
```c#
    var magoFogo = new MagoDeFogo("Mago Fogo", 100);
    magoFogo.LancarFeitico("Bola de Fogo");
    magoFogo.LancarFeitico("Raio Congelante"); // Usará o método da classe base

    var magoGelo = new MagoDeGelo("Mago Gelo", 80);
    magoGelo.LancarFeitico("Estaca de Gelo");
    magoGelo.LancarFeitico("Bola de Fogo"); // Usará o método da classe base
```
    

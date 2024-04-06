```c#
internal class Cachorro
{
    private string nome; //atributos geralmente são privados
    private int idade; //só é visivel dentro da classe
    public bool Castrado { get; set; } //auto-implemented property

    public string Nome
    {
        get { return nome != null ? nome : "vira-lata"; }
        set { nome = value; }
    }
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 0)
            {
                idade = 0;
            }
            else
            {
                idade = value;
            }
        }
    }

    public void Dormir() //geral metodos são publicos
    {
        Console.WriteLine(nome + "A mimir");
    }

    public void PegarBola()
    {
        Console.WriteLine("Pegou a Bola...");
    }

}
```
Os atributos nome e idade são declarados como private. Isso significa que eles só são visíveis dentro da classe Cachorro. 

- Os atributos nome e idade são privados para proteger os dados do cachorro.
- As propriedades Nome e Idade fornecem acesso controlado a esses dados.
- Os métodos Dormir e PegarBola definem a funcionalidade pública da classe.

## C# também possui outros modificadores de acesso:

- private protected: acessível apenas dentro da classe e classes derivadas no mesmo assembly.
- internal: acessível apenas dentro do mesmo assembly.(projeto)
 - Exemplo:  Se você está criando um biblioteca com classes uteis e algumas classes são apenas para facilitar a construção de classes principais(expostas externamente - public), então o internal é interessante para proteger e evitar que os usuários se confundam com a chamada de classes e métodos que eles não sabem usar.
- protected: acessível apenas dentro da classe e classes derivadas.

## As propriedades autoimplementadas 
Tornam a declaração de propriedade mais concisa quando nenhuma lógica adicional for necessária nos acessadores de propriedade. Elas também habilitam o código do cliente a criar objetos. Ao declarar uma propriedade, como mostrado no exemplo a seguir, o compilador cria um campo de suporte privado e anônimo que pode ser acessado somente por meio dos acessadores get e set da propriedade. 
Conseguimos definir um valor default como em um campo

```c#
public class ContaCorrente
{
    private double Saldo { get; set; } = 200.0;   
    public string Titular{get;set;}= "Não identificado"; 
}
```
Outro padrão

```c#
public class Pessoa
{
    private string _nome;
    public string Nome {
        get { return _nome.ToLower(); }
        set { _nome = value.Trim().ToUpper(); }
    }
}

```

# readonly
é como se o set estivesse privado, o atributo precisa ser definido anteriormente no construtor ou no atributo

```c#
class Pessoa
{
    public readonly string Nome = "Paloma";
}
```
ou 
```c#
class Pessoa
{
    public readonly string Nome;
    Pessoa()
    {
        Nome = "Paloma"
    }
}
```

```c#
    Pessoa pessoa = new Pessoa();
    Console.Write(pessoa.Nome);
    pessoa.Nome = "Ana" //erro

```

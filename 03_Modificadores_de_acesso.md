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
- internal: acessível apenas dentro do mesmo assembly.
- protected: acessível apenas dentro da classe e classes derivadas.

## As propriedades autoimplementadas 
Tornam a declaração de propriedade mais concisa quando nenhuma lógica adicional for necessária nos acessadores de propriedade. Elas também habilitam o código do cliente a criar objetos. Ao declarar uma propriedade, como mostrado no exemplo a seguir, o compilador cria um campo de suporte privado e anônimo que pode ser acessado somente por meio dos acessadores get e set da propriedade. 
Conseguimos definir um valor default como em um campo

```c#
public class ContaCorrente
{
    public double Saldo { get; set; } = 200.0;   
    public string Titular{get;set;}= "Não identificado"; 
}
```
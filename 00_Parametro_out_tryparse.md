# Parâmetro out 
Em C#, o parâmetro out é usado para passar uma variável por referência a um método. Isso significa que o método pode modificar o valor da variável original passada como argumento.

```C#
public static void DobrarValor(int valor, out int valorDobrado)
{
  valorDobrado = valor * 2;
}

public static void Main(string[] args)
{
  int numero = 5;
  DobrarValor(numero, out int resultado);
  Console.WriteLine("Valor dobrado: " + resultado);  // Output: Valor dobrado: 10
}
```
# TryParse
O método TryParse (disponível em muitos tipos de dados) tenta converter um valor de um tipo para outro. Diferentemente de Parse, o TryParse não lança uma exceção se a conversão falhar. Em vez disso, ele retorna true se a conversão for bem-sucedida e false se falhar.

```C#
string valorString = "10";
int valorInt;

if (int.TryParse(valorString, out valorInt))
{
  Console.WriteLine("Conversão bem-sucedida: " + valorInt);
}
else
{
  Console.WriteLine("Erro na conversão!");
}

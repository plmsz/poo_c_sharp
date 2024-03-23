```C#
Console.WriteLine("Digite um número");

try
{
    int numero = int.Parse(Console.ReadLine());
    int num = int.Parse(null);
}
catch (FormatException)
{
    Console.WriteLine("Não foi localizado número digitado");
}catch (Exception)
{
    Console.WriteLine("Tratado pela classe pai");
}finally
{
    Console.WriteLine("FIM");
}
Console.ReadKey();
```
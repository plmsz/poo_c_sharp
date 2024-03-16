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
  public Mago(string nome) { ... }
  public Mago(string nome, int poderMagico) { ... }
}

Mago mago1 = new Mago("Merlin");
Mago mago2 = new Mago("Gandalf", 200);
```
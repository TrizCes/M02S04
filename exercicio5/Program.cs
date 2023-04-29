using exercicio5;

class Program
{
  static void Main(string[] args)
  {
    Pessoa ela = new Pessoa();

    Console.WriteLine(ela.getNome());
    Console.WriteLine(ela.getIdade());

    ela.DefinirNome("Maria");
    Console.WriteLine(ela.getNome());

    ela.DefinirIdade(-18);
    Console.WriteLine(ela.getIdade());

    ela.DefinirIdade(18);
    Console.WriteLine(ela.getIdade());

  }
}

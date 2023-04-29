using exercicio5;

class Program
{
  static void Main(string[] args)
  {
    Pessoa ela = new Pessoa();

    Console.WriteLine("   Inicio: ");
    Console.WriteLine("Nome: " + ela.Nome);
    Console.WriteLine("Idade: " + ela.Idade + "\n");

    Console.WriteLine("   Definindo Nome: ");
    ela.DefinirNome("Maria");
    Console.WriteLine("Nome: " + ela.Nome + "\n");

    Console.WriteLine("   Definindo Idade negativa: ");
    ela.DefinirIdade(-18);
    Console.WriteLine("Idade: " + ela.Idade + "\n");

    Console.WriteLine("   Definindo Idade correta: ");
    ela.DefinirIdade(18);
    Console.WriteLine("Idade: " + ela.Idade);

  }
}

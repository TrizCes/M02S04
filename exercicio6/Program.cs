using exercicio6;

class Program
{
  static void Main(string[] args)
  {
    Retangulo r1 = new();

    Console.WriteLine("iniciando variaveis...");
    r1.Altura = -1;
    r1.Altura = 5;
    r1.Largura = -6;
    r1.Largura = 3;
    Console.WriteLine("Nosso retângulo: ");
    Console.Write("Altura: ");
    Console.WriteLine(r1.Altura);
    Console.Write("Largura: ");
    Console.WriteLine(r1.Largura);
    Console.Write("Area do retângulo: ");
    Console.WriteLine(r1.CalculaArea());

  }
}

using exercicio6;

class Program
{
  static void Main(string[] args)
  {
    Retangulo r1 = new();

    Console.WriteLine("iniciando variaveis...");
    r1.SetAltura(-1);
    r1.SetAltura(5);
    r1.SetLargura(-6);
    r1.SetLargura(5);
    Console.WriteLine("Nosso retângulo: ");
    Console.Write("Altura: ");
    Console.WriteLine(r1.GetAltura());
    Console.Write("Largura: ");
    Console.WriteLine(r1.GetLargura());
    Console.Write("Area do retângulo: ");
    Console.WriteLine(r1.CalculaArea());

  }
}

namespace exercicio9
{
  class Program
  {
    private static void Main(string[] args)
    {
      Console.WriteLine("Valor de Pi: " + Calculadora.PI);

      int a = 12;
      int b = 5;

      Console.WriteLine("Soma: " + Calculadora.Soma(a, b));
      Console.WriteLine("Subtração: " + Calculadora.Subtracao(a, b));
      Console.WriteLine("Multiplicação: " + Calculadora.Multiplicacao(a, b));
      Console.WriteLine("Divisão: " + Calculadora.Divisao(a, b));

      int c = 12;
      int d = 0;

      Console.WriteLine("Soma: " + Calculadora.Soma(c, d));
      Console.WriteLine("Subtração: " + Calculadora.Subtracao(c, d));
      Console.WriteLine("Multiplicação: " + Calculadora.Multiplicacao(c, d));
      Console.WriteLine("Divisão: " + Calculadora.Divisao(c, d));
    }
  }
}
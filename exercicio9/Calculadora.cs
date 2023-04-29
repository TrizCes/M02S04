using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio9
{
  public static class Calculadora
  {
    public const double PI = 3.14159265359;
    public static int Soma(int num1, int num2)
    {
      return num1 + num2;
    }

    public static int Subtracao(int num1, int num2)
    {
      return num1 - num2;
    }
    public static int Multiplicacao(int num1, int num2)
    {
      return num1 * num2;
    }

    public static double Divisao(int num1, int num2)
    {
      if (num2 == 0)
      {
        Console.WriteLine("Não é possivel realizar divisão por 0");
        return 0;
      }
      return num1 / num2;
    }
  }
}
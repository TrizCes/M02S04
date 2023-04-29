using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio6
{
  public class Retangulo
  {
    private double Largura;
    private double Altura;
    public void SetLargura(double largura)
    {
      if (largura > 0)
      {
        Largura = largura;
      }
      else
      {
        System.Console.WriteLine("A largura deve ser um numero positivo");
      }

    }

    public void SetAltura(double altura)
    {
      if (altura > 0)
      { Altura = altura; }
      else
      {
        System.Console.WriteLine("A altura deve ser um numero positivo");
      }
    }

    public double GetLargura()
    {
      return Largura;
    }

    public double GetAltura()
    {
      return Altura;
    }

    public double CalculaArea()
    {
      return Largura * Altura;
    }
  }
}
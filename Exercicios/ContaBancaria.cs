using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios
{
  public class ContaBancaria
  {
    private int NumeroDaConta { get; set; }
    private double Saldo { get; set; }

    public ContaBancaria(int numeroDaConta, double saldo)
    {
      NumeroDaConta = numeroDaConta;
      Saldo = saldo;
    }

    public void Depositar(double valor)
    {
      Saldo += valor;
    }

    public void Saca(double valor)
    {
      if (Saldo >= valor)
      {
        Saldo -= valor;
      }
      else
      {
        Console.WriteLine("Saldo insuficiente");
      }
    }

    public double getSaldo()
    {
      return Saldo;
    }
  }
}

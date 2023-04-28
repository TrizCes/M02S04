using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4
{
  public class ContaBancaria
  {
    private double saldo;

    public double Saldo
    {
      get { return saldo; }
      set { if (value >= 0) { saldo = value; }; }
    }

    public ContaBancaria() { }

    public ContaBancaria(double saldo)
    {
      this.saldo = saldo;
    }

    public void Depositar(double valor)
    {
      this.saldo += valor;
    }

    public bool Saca(double valor)
    {
      if (this.saldo >= valor)
      {
        this.saldo -= valor;
        return true;
      }
      else
      {
        Console.WriteLine("Saldo insuficiente");
        return false;
      }
    }

    public override string ToString()
    {
      return $"Saldo: {saldo}";
    }
  }
}
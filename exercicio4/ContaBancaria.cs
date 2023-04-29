using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio4
{
  public class ContaBancaria
  {
    private decimal saldo;

    public decimal Saldo
    {
      get { return saldo; }
      set { saldo = value >= 0 ? value : 0; }
    }

    public ContaBancaria() { }

    public ContaBancaria(decimal saldo)
    {
      this.saldo = saldo;
    }

    public void Depositar(decimal valor)
    {
      this.saldo += valor;
    }

    public bool Saca(decimal valor)
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
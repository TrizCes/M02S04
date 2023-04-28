using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
  public class Banco
  {
    private double saldo { get; set; }

    public Banco(double saldo)
    {
      this.saldo = saldo;
    }

    public void Depositar(double value)
    {
      this.saldo += value;
    }
    public void Saque(double value)
    {
      this.saldo -= value;
    }

    public override string ToString()
    {
      return $"Saldo: {this.saldo.ToString()}.";
    }
  }
}

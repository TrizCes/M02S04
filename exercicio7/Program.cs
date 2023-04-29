using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      ContaBancaria c1 = new();

      c1.NumeroDaConta = 4569;
      c1.Depositar(985);
      c1.Sacar(500);
      c1.Depositar(19965);
      c1.Depositar(19000);
      c1.Sacar(4000);
    }
  }
}

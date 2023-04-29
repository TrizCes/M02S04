using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio7
{
  public class ContaBancaria
  {
    public int NumeroDaConta { get; set; }
    private decimal Saldo { get; set; }
    public const decimal SaldoMaximo = 20000;

    public void Depositar(decimal valor)
    {
      decimal result = Saldo + valor;
      if (valor > 0 && valor <= SaldoMaximo && result <= SaldoMaximo)
      {
        Saldo += valor;
        Console.WriteLine($"Depósito realizado com sucesso!. Saldo atual de: {Saldo}");
      }
      else
      {
        Console.WriteLine("Não foi possivel depositar! \n Não podemos realizar depositos negativos ou que ultrapassem o nosso limite máximo!");
      }
    }
    public void Sacar(decimal valor)
    {
      if (valor > 0 && Saldo > valor)
      {
        Saldo -= valor;
        System.Console.WriteLine("Saque realizado com sucesso!. Saldo atual de: " + Saldo);
      }
      else
      {
        System.Console.WriteLine("Valor inválido para saque!");
      }
    }
  }
}
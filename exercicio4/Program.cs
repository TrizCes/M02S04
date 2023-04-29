using exercicio4;

class Program
{
  static void Main(string[] args)
  {
    ContaBancaria c1 = new ContaBancaria();

    Console.WriteLine(c1.ToString());
    c1.Depositar(2600);
    Console.WriteLine(c1.ToString());
    c1.Saca(452);
    Console.WriteLine(c1.ToString());
    c1.Saca(2354);
    Console.WriteLine(c1.ToString());
    Console.WriteLine(c1.Saldo);
    c1.Saldo = 123;
    Console.WriteLine(c1.Saldo);

  }
}

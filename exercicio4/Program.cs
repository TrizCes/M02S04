using exercicio4;

class Program
{
  static void Main(string[] args)
  {
    ContaBancaria c1 = new ContaBancaria();

    Console.WriteLine(c1.ToString());
    c1.Depositar(2600.54);
    Console.WriteLine(c1.ToString());
    c1.Saca(452.65);
    Console.WriteLine(c1.ToString());
    c1.Saca(2354.50);
    Console.WriteLine(c1.ToString());
    Console.WriteLine(c1.Saldo);
    c1.Saldo = 123;
    Console.WriteLine(c1.Saldo);

  }
}

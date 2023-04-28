using Banco;
class Program
{
  static void Main(string[] args)
  {
    double valor = 0;

    Cliente cliente1 = new Cliente("João Silva", "123.456.789-12");
    ContaBancaria conta1 = new ContaBancaria(1234, cliente1);

    Console.WriteLine("Dados da conta:");
    Console.WriteLine(conta1.ToString());
    Console.WriteLine(cliente1.ToString());
    Console.WriteLine("Qual valor você gostaria de Depositar:");
    valor = double.Parse(Console.ReadLine());
    conta1.Depositar(valor);
    conta1.ExibirDados();
    Console.WriteLine("Qual valor você gostaria de Sacar:");
    valor = double.Parse(Console.ReadLine());
    conta1.Saque(valor);
    conta1.ExibirDados();
  }
}

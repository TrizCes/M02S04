using Exercicios;

Pessoa Pessoa1 = new Pessoa("Beatriz", 28, "Rua: ");

// Pessoa1.Saudacao();

ContaBancaria conta1 = new ContaBancaria(369, 2355.65);

Console.WriteLine(conta1.getSaldo());
conta1.Depositar(50);
Console.WriteLine(conta1.getSaldo());
conta1.Saca(400);
Console.WriteLine(conta1.getSaldo());
conta1.Saca(2400);
Console.WriteLine(conta1.getSaldo());
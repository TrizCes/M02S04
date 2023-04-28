using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
  public class ContaBancaria
  {
    private int numero;
    private Cliente? cliente;

    private Banco banco = new Banco(0);
    public ContaBancaria() { }

    public ContaBancaria(int numero, Cliente cliente)
    {
      this.numero = numero;
      this.cliente = cliente;
    }

    public void ExibirDados()
    {
      Console.WriteLine($"Conta: {this.numero}, {this.cliente.ToString()}, {banco.ToString()} ");
    }

    public override string ToString()
    {
      return $"Conta: {this.numero}";
    }

    public void Depositar(double value)
    {
      banco.Depositar(value);
    }
    public void Saque(double value)
    {
      banco.Saque(value);
    }


    /*
     Adicionamos um método público "ExibirDados" que exibe o número da conta, o nome do cliente e o cpf do cliente. Também adicionamos métodos "Depositar" e "Sacar", que redirecionam as operações para o objeto da classe "Banco". Por fim, adicionamos um método "ToString" que retorna uma string formatada com o número da conta, o nome do cliente, o cpf do cliente e o saldo da conta.
     */
  }
}

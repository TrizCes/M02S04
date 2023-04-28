using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banco
{
  public class Cliente
  {
    private String nome { get; set; }
    private String cpf { get; set; }
    public Cliente(string nome, string cpf)
    {
      this.nome = nome;
      this.cpf = cpf;
    }

    public override string ToString()
    {
      return $"Nome: {this.nome.ToString()}, CPF: {this.cpf.ToString()}";
    }
  }
}

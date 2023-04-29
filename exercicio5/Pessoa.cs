using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5
{
  public class Pessoa
  {
    private string nome { get; set; }
    private int idade { get; set; }

    public string Nome
    {
      get { return nome; }
      set { nome = value; }
    }

    public int Idade
    {
      get { return idade; }
      set { idade = value > 0 ? value : 0; }
    }
    public Pessoa() { }
    public Pessoa(string nome, int idade)
    {
      Nome = nome;
      Idade = idade;
    }
    public void DefinirIdade(int idade)
    {
      if (idade > 0)
      {
        Idade = idade;
      }
    }

    public void DefinirNome(string nome)
    {
      Nome = nome;
    }
  }
}
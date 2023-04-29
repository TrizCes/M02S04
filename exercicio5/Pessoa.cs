using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio5
{
  public class Pessoa
  {
    private string? nome { get; set; }
    private int idade { get; set; }
    public Pessoa() { }
    public Pessoa(string nome, int idade)
    {
      this.nome = nome;
      this.idade = idade;
    }


    public void DefinirIdade(int idade)
    {
      if (idade > 0)
      {
        this.idade = idade;
      }
    }

    public void DefinirNome(string nome)
    {
      this.nome = nome;
    }

    public int getIdade() { return this.idade; }
    public string getNome() { return this.nome; }
  }
}
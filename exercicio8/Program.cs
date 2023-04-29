using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      Cachorro pet1 = new Cachorro();
      Gato pet2 = new Gato();

      pet1.Nome = "Dobby";
      pet1.Idade = 12;

      pet2.Nome = "Nice";
      pet2.Idade = 2;

      Console.WriteLine($"\nO nome do meu cachorro é {pet1.Nome}, ele tem {pet1.Idade} anos. O {pet1.Nome} diz:");
      pet1.EmitirSom();

      Console.WriteLine($"\nO nome da minha gata é {pet2.Nome}, ela tem {pet2.Idade} anos. A {pet2.Nome} diz:");
      pet2.EmitirSom();
    }
  }
}
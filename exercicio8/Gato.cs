using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exercicio8
{
  public class Gato : Animal
  {
    public override void EmitirSom()
    {
      Console.WriteLine("Miau!");
    }
  }
}
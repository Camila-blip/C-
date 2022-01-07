
Using System;

namespace Curso{
  class Programa{
    static void Main(string[] args){
      string Nome = "Camila Moura";
      int Idade = 20;
      string.Format("Meu nome é {0} e tenho {} anos", Nome, Idade)
        //Interpolação
       Console.WeiteLine($"{Nome} tem {Idade}")
       Console.WeiteLine("{0} {2:F2} reais", Nome, Idade)
    }
  }
}

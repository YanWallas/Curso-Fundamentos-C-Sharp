using System;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      SobreGuid();

    }

    static void SobreGuid()
    {
      var id = Guid.NewGuid();//criando um ID (números grande) aleatorio.
      id.ToString();//tranformando em string

      id = new Guid("82b0e170-573e-451b-b9af-4ea63bd78440");//jogando a strind dentro so id

      //New Guid - a gente passa o que era criado. 
      //id = new Guid();//Se eu nao passar nada dentro do New guid, gera tudo 0000000.

      Console.WriteLine(id.ToString().Substring(0, 8));//pegando apenas os 8 primeiros numeros.
    }
  }
}

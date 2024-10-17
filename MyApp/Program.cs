using System;
using System.Xml;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //SobreGuid();
      InterpolacaoString();

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

    static void InterpolacaoString()
    {
      var price = 10.2;
      var texto = "O preço do produto é " + price + " (apenas na promoção)";//interpoloção de string (juntando tipos diferentes na string)
      Console.WriteLine(texto);
      Console.WriteLine("-------------------------");

      //OUTRA FORMA
      var texto1 = string.Format("O valor é {0} (apenas na promoção)", price);
      Console.WriteLine(texto1);
      Console.WriteLine("-------------------------");

      //OUTRA FORMA
      var texto2 = $"O preço é {price}";
      Console.WriteLine(texto2);
    }
  }
}

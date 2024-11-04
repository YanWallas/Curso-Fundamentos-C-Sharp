using System;
using System.Xml;

namespace MyApp
{
  class Program
  {
    static void Main(string[] args)
    {
      //SobreGuid();
      //InterpolacaoString();
      //ComparacaoString();
      //ComecaCom();
      //Iguais();
      Indices();

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

    static void ComparacaoString()
    {
      var texto = "Testando";
      Console.WriteLine(texto.CompareTo("Testando"));//Igual da 0
      Console.WriteLine(texto.CompareTo("testando"));//Diferente da 1
      Console.WriteLine("-------------------------");

      var texto1 = "Este texto é teste";
      Console.WriteLine(texto1.Contains("teste"));//esse texto contem a palavra teste.
      Console.WriteLine(texto1.Contains("Teste"));//Diferente pelo 'T' maiusculo.
      Console.WriteLine(texto1.Contains("Teste", StringComparison.OrdinalIgnoreCase));//Vai ignorar a letra maiuscula ou minuscula e comparar a string.
    }

    static void ComecaCom() //StartsWith
    {
      var texto = "Este texto é teste";
      Console.WriteLine(texto.StartsWith("Este"));//Começa com 'Este' maiusculo = true
      Console.WriteLine(texto.StartsWith("este"));//Começa com 'este' minusculo = false
      Console.WriteLine("-------------------------");

      Console.WriteLine(texto.EndsWith("Teste"));//Termina com 'Teste' maiusculo = false
      Console.WriteLine(texto.EndsWith("teste"));//Termina com 'teste' minusculo = true
    }

    static void Iguais() //Equals
    {
      var texto = "Este texto é igual";
      Console.WriteLine(texto.Equals("Este texto é igual"));//Se o texto é igual = true
      Console.WriteLine(texto.Equals("este texto é igual"));//com minusculo nao é igual = false
      Console.WriteLine("-------------------------");
    }

    static void Indices() {
      var texto = "Este texto é um teste";
      Console.WriteLine(texto.IndexOf("é")); // Ela esta na posição 11 dos caracteres.
      Console.WriteLine(texto.IndexOf("um")); // Vai pegar a primeira posição do caracter (é 13)
      Console.WriteLine(texto.LastIndexOf("s"));// #LastIndexOf - Ultimo index que ele encontrar do caracter (é 18)
    }

  }
}

// Importações
using System;
using System.Diagnostics.Contracts;
using System.Runtime;
using Operadores;


//Namespace
namespace MeuApp
{
  //Classe principal do programa
  class Program
  {
    //Função principal do programa
    static void Main(string[] args)
    {
      //Chamdno a funcão.
      UsandoIF();
      UsandoSwitch();
      UsandoFor();
      UsandoWhile();
      MeuMetodo();
      TypesValue();

      string nome = RetornaNome("Andre", "Augusto");
      Console.WriteLine(nome);

      Product mouse = new Product(1, "Mouse Gamer", 299.97, EProductType.Product);
      var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);
      Console.WriteLine(mouse.Id);
      Console.WriteLine(mouse.Name);
      Console.WriteLine(mouse.Price);
      Console.WriteLine(mouse.Type);
    }

    static void UsandoIF()

    {
      Console.WriteLine("Usando IF");//-------------------------------
      int num = 25;
      if (num != 32)
      {
        Console.WriteLine("Não é igual");
      }
      else
      {
        Console.WriteLine("È igual");
      }

      Console.WriteLine("............................");

      int idade = 18;
      int maioridade = 21;

      if (idade >= maioridade)
      {
        Console.WriteLine("Você é maior de idade");
      }
      else
      {
        Console.WriteLine("Você não é maior de idade");
      }
      Console.WriteLine("............................");
    }

    static void UsandoSwitch()
    {
      Console.WriteLine("Usando switch ");//-------------------------------
      string valor = "paulo";
      switch (valor)
      {
        case "joao":
          Console.WriteLine("Nome: João");
          break;
        case "paulo":
          Console.WriteLine("Nome: Paulo");
          break;
        case "maria":
          Console.WriteLine("Nome: Maria");
          break;
        default:
          Console.WriteLine("Nome desconhecido");
          break;
      }
      Console.WriteLine("............................");
    }

    static void UsandoFor()
    {
      Console.WriteLine("USANDO FOR (Aumentando)");//-------------------------------
      for (var i = 0; i <= 5; i++)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("............................");

      Console.WriteLine("USANDO FOR (Diminuindo)");//-------------------------------
      for (var i = 5; i >= 0; i--)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("............................");
    }

    static void UsandoWhile()
    {
      Console.WriteLine("USANDO WHILE (enquanto) - checa antes");//-------------------------------
      int valor1 = 0;
      while (valor1 <= 5)
      {
        Console.WriteLine(valor1);
        valor1++;
      }
      Console.WriteLine("............................");

      Console.WriteLine("USANDO do/while (faça) - checa depois");//-------------------------------
      var valor2 = 0;
      do
      {
        Console.WriteLine(valor2);
        valor2++;
      } while (valor2 < 5);
      Console.WriteLine("............................");
    }

    static void MeuMetodo()
    {
      Console.WriteLine("C# é legal");
    }

    static string RetornaNome(
      string nome1,
      string sobrenome1,
      int idade1 = 34) //parametro opcional.
    {
      return nome1 + " " + sobrenome1 + " tem " + idade1.ToString();

    }

    static void TypesValue()
    {
      Console.WriteLine("Usando types value");//criando Copia do value.
      int x = 25;
      int y = x;
      Console.WriteLine(x);
      Console.WriteLine(y);

      x = 32;
      Console.WriteLine(x);
      Console.WriteLine(y);

      Console.WriteLine("Usando types referencia");//criando referencia do value.
      var arr = new string[2];
      arr[0] = "Item 1";

      var arr2 = arr;

      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);

      arr[0] = "Item 2";
      Console.WriteLine(arr[0]);
      Console.WriteLine(arr2[0]);
    }
  }

  struct Product // struct - Estrutura
  {
    public Product(int id, string name, double price, EProductType type)
    {
      Id = id;
      Name = name;
      Price = price;
      Type = type;
    }

    public int Id;
    public string Name;
    public double Price;
    public EProductType Type;

    public double PriceInDolar(double dolar)
    {
      return Price * dolar;
    }

  }

  enum EProductType //numerador
  {
    Product = 1,
    Service = 2
  }
}

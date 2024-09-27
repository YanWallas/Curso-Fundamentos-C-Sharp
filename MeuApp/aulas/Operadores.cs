using System;

namespace Operadores
{
  class Operadores
  {
    static void DeclarandoVariaveis()
    {
      int x = 2;
      x = 2 / 2;
      Console.WriteLine(x);

      //DECLARANDO VARIAVEIS;
      /*
      int idade; // Correto incia com Zero
      int idade = 25; // Correto incia com 25
      var idade = 25; // Correto incia com 25
      var idade; // Errado 
      */

      //DECLARANDO CONSTANTS; const NÃO PODEM ser alteradas
      /*
      const int IDADE_MINIMA; // Correto inicia com zero
      const int IDADE_MAXIMA = 25; // Correto inicia com 25
      const var IDADE_MINIMA = 25; // Errado
      const var IDADE_MAXIMA; // Errado 
      */

      //NÚMEROS INSTEIROS
      /*
      short idade = 25; // negatico ou positivo 
      ushort  idade = 25; // apenas positivos
      int idade = 25; // negativo ou positivo
      uint  idade = 25; // apenas positivos 
      long idade = 25; // negativos ou positivos 
      ulong idade = 25; // apenas positivos
      */

      //NÚMEROS REAIS = conversão padrao é double.
      /*
      float salario = 2.500f; // colocar f para definir que é float
      double salarioSemestral = 22.000; // Não precisa identificar
      decimal  salarioAnual = 25.000m; //  colocar m para definir que é float
      */

      //NÚMEROS BOOLEAN = bool para definir variavel true ou false.
      /* 
      bool usuarioJaCadastrado = false;
      bool pagamentoRecebido = true;
      var usuarioExpirado = false; // var identifica automatico o bool.
      */

      //ARMAZENAR UM CARACTER = Utilizar char com aspas simples ''.
      /* 
      char primeiraletra = 'C';
      var segundaLetra = 'D'; // var identifica automatico o char.
      */

      //ARMAZENAR CARACTER = Utilizar string com aspas duplas " ".
      /* 
      string primeiraletra = 'C';
      string texto = "Meu texto";
      var documento = "12345.6789"; // var identifica automatico o string.
      */

      //VAR  = Substitui o nome de qualquer tipo (será o tipo do primeiro valor atribuído).
      /* 
      var idade = 25; // Vai Atribuir tipo int
      var texto = "Meu texto"; // Vai Atribuir tipo string
      var segundaLetra = 'D'; // var identifica automatico o char.
      var usuarioExpirado = false; // var identifica automatico o bool.
      */

      //OBJECT  = tipo qualquer (Será qualquer coisa).
      /* 
      object quantidade;// 
      quantidade = 1; 
      quantidade = 2.5; // vai aceitar, pq defini como qualquer coisa.
      quantidade = "Teste"; // vai aceitar tbm.
      */

      //NULLABE TYPE  = tipo NULL (precisa colocar o ponto de interrogação, se não, vai da erro).
      /*
      int? idade = null;
      */

      //CONVERSÃO PARSE E CONVERT
      /*int inteiro = 100;
      float real = 25.5f;

      //real = inteiro; // passou a valer 100.0f
      //inteiro = (int)real; // passou a valer 25
      //string valorReal = real.ToString(); // Tranformando o real em string com ToString();
      //inteiro = int.Parse(valorReal); // parse nesse caso nao consegui transformar. So aceita string.
      inteiro = Convert.ToInt32(real); //convert num real em inteiro, convert para cima

      //Console.WriteLine(valorReal); //
      Console.WriteLine(inteiro); */
    }

  }
}
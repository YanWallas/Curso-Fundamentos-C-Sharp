using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Soma();
        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());//Tranformando a string em números.

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());//Tranformando a string em números.

            Console.WriteLine("");

            float resultado = v1 + v2;
            Console.WriteLine($"O resultado é {resultado}");
        }
    }
}

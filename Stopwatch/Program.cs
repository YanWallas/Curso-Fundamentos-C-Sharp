using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start(6);
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - segundos => 10s = 10 Segundos");
            Console.WriteLine("M = Minutos => 1m = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();//ToLower deixa tudo minusculo.
            char type = char.Parse(data.Substring(data.Length - 1, 1));//Pegando ultima caracter.

            Console.WriteLine(data);
            Console.WriteLine(type);
        }

        static void Start(int time)
        {
            int currenTime = 0;

            while (currenTime != time)
            {
                Console.Clear();
                currenTime++;
                Console.WriteLine(currenTime);
                Thread.Sleep(1000);//a cada interação, atrasa 1seg a tela.
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado..");
            Thread.Sleep(2500);
        }

    }
}

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
            int time = int.Parse(data.Substring(0, data.Length - 1));//Pegando o tempo antes do caracter.
            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;
            if (time == 0)
                System.Environment.Exit(0);

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1500);

            Start(time);
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
            Thread.Sleep(1500);
            Menu();
        }

    }
}

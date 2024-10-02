using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start(6);
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

using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        static void Start()
        {
            int time = 10;
            int currenTime = 0;

            while (currenTime != time)
            {
                currenTime++;
                Console.WriteLine(currenTime);
            }
        }

    }
}

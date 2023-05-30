using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Seconds => 10s = 10 Seconds");
            Console.WriteLine("M = Minute => 1m = 1 Minute");
            Console.WriteLine("0 = Exit");
            Console.WriteLine("How many time would you like to count ?");

            string data = Console.ReadLine();

            if (data.Length == 1)
            {
                if (data == "0")
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You need to specify the value with minutes or seconds. Eg. 3s");
                    Thread.Sleep(2500);
                    Menu();
                }

            }

            data = data.ToLower();
            char type = char.Parse(data.Substring((data.Length - 1), 1));
            int time = int.Parse(data.Substring(0, (data.Length - 1)));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

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

            Thread.Sleep(2500);

            Start(time);
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}

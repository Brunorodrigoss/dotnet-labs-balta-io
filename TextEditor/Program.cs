﻿using System;

namespace TextEditor
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
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Open file");
            Console.WriteLine("2 - Create new file");
            Console.WriteLine("0 - Exit");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Where the file is located ?");
            Console.WriteLine("---------------------------");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.Read();
            Menu();

        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Type your text below (ESC to Exit): ");
            Console.WriteLine("------------------------------------");
            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("Which path would you like to save the file ?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"File {path} successfully saved!");
            Console.ReadLine();
            Menu();
        }
    }
}

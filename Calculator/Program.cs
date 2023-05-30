using System;

namespace MeuApp
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

            Console.WriteLine("O que deseja fazer ?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");
            Console.WriteLine("Selecione uma opção: ");

            ushort res = ushort.Parse(Console.ReadLine());

            switch (res)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static (float v1, float v2) GetValues()
        {
            Console.Clear();

            Console.WriteLine("Primeiro Valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Valor: ");
            float v2 = float.Parse(Console.ReadLine());

            return (v1, v2);
        }

        static void ShowResult(float result, string operation)
        {
            Console.WriteLine("");
            Console.WriteLine($"O resultado da {operation} é {result}");
            Console.ReadKey();

            Menu();
        }

        static void Soma()
        {
            var (v1, v2) = GetValues();
            float resultado = v1 + v2;
            ShowResult(resultado, "soma");
        }

        static void Subtracao()
        {
            var (v1, v2) = GetValues();
            float resultado = v1 - v2;
            ShowResult(resultado, "subtração");
        }

        static void Divisao()
        {
            var (v1, v2) = GetValues();
            float resultado = v1 / v2;
            ShowResult(resultado, "divisão");
        }

        static void Multiplicacao()
        {
            var (v1, v2) = GetValues();
            float resultado = v1 * v2;
            ShowResult(resultado, "multiplicação");
        }

    }
}
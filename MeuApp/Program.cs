using System;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mouse = new Product(1, "Mouse Gamer", 987.65, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção Eletrica Residencial", 500, EProductType.Service);

            Console.WriteLine(mouse.Price);

            mouse.Price = 99.99;

            Console.WriteLine(mouse.Price);

            Console.WriteLine((int)mouse.Type);
        }
    }
}
using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UsingGuid();
        }

        static void UsingGuid()
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);
        }
    }


}
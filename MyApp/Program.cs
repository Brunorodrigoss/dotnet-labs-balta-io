using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringInterpolation();
        }

        static void UsingGuid()
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id);
        }

        static void StringInterpolation()
        {
            var price = 10.2 + 9;
            // var text = "The price of the product is " + price + " just in promotions.";
            // var text = string.Format("The price of the product is {0} just in promotions.", price);
            //var text = $"The price of hte product is {price} just in promotions.";

            //var text = $@"The price of the 
            //product is {price} just in promotions.";

            var text = $"The price of the \n product is {price} just in promotions.";
            Console.WriteLine(text);
        }

    }


}
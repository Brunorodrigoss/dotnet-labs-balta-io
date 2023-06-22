using System;
using System.Text;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "This text is a test";
            StringBuilder();
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

        static void StringComparisions(string text)
        {
            Console.WriteLine(text.CompareTo("This text is a test"));
            Console.WriteLine(text.CompareTo("this text is a test"));

            Console.WriteLine(text.Contains("test"));
            Console.WriteLine(text.Contains("this"));
            Console.WriteLine(text.Contains("this", StringComparison.OrdinalIgnoreCase));
        }

        static void StartsWith(string text)
        {
            Console.WriteLine(text.StartsWith("This"));
            Console.WriteLine(text.StartsWith(" This"));
            Console.WriteLine(text.StartsWith("this"));
            Console.WriteLine(text.StartsWith("this", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine(text.StartsWith("text"));
        }

        static void EndsWith(string text)
        {
            Console.WriteLine(text.EndsWith("test"));
            Console.WriteLine(text.EndsWith("Test"));
            Console.WriteLine(text.EndsWith("xpto"));
        }

        static void EqualsString(string text)
        {
            Console.WriteLine(text.Equals("This text is a test"));
            Console.WriteLine(text.Equals("this text is a test"));
            Console.WriteLine(text.Equals("this text is a test", StringComparison.OrdinalIgnoreCase));
        }

        static void IndexString(string text)
        {
            Console.WriteLine(text.IndexOf("a"));
            Console.WriteLine(text.LastIndexOf("t"));
        }

        static void UpperAndLower(string text)
        {
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
        }


        static void InsertAndRemove(string text)
        {
            text = text.Insert(5, "HERE ");

            Console.WriteLine(text);

            text = text.Remove(5, 5);
            Console.WriteLine(text);
        }

        static void Replace(string text)
        {
            Console.WriteLine(text.Replace("This", "this"));
        }

        static void Split(string text)
        {
            var div = text.Split(" ");
            Console.WriteLine(div[0]);
            Console.WriteLine(div[1]);
            Console.WriteLine(div[2]);
            Console.WriteLine(div[3]);
            Console.WriteLine(div[4]);
        }

        static void Substring(string text)
        {
            //var result = text.Substring(5, 4);
            var result = text.Substring(5, text.LastIndexOf("x"));
            Console.WriteLine(result);
        }

        static void Trim()
        {
            var text = "  This text is a test  ";
            Console.WriteLine(text.Trim());
        }

        static void StringBuilder()
        {
            var text = new StringBuilder();
            text.Append("This text is a test ");
            text.Append("This text is a test 2 ");
            text.Append("This text is a test 3 ");
            text.Append("This text is a test 4 ");

            Console.WriteLine(text.ToString());
        }
    }
}
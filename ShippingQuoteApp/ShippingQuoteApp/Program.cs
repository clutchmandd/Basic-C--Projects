using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuoteApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();

            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine());

            if (weight > 50)
            {
                Console.WriteLine("This package is too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int length = Convert.ToInt32(Console.ReadLine());

            int dimensions = width + height + length;

            if (dimensions > 50)
            {
                Console.WriteLine("This package is too big to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                Environment.Exit(0);
            }
            else
            {
                decimal quote = ((width * height * length) * weight) / 100M;
                Console.WriteLine("Your estimated shipping cost for this package is $" + quote.ToString("F"));
                Console.WriteLine("Thank You!");
                Console.ReadLine();
            }
        }
    }
}

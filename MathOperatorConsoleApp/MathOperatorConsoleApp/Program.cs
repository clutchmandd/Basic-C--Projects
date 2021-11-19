using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes an input from user and multiplies it by 50
            Console.WriteLine("Please enter a number:");
            string num1entry = Console.ReadLine();
            long num1 = Convert.ToInt64(num1entry);
            long num2 = num1 * 50;
            Console.WriteLine("Your number multiplied by 50 = " + num2);
            Console.ReadLine();

            //Takes an input from user and adds 25 to it
            Console.WriteLine("Please enter another number:");
            string num2entry = Console.ReadLine();
            long num3 = Convert.ToInt64(num2entry);
            long num4 = num3 + 25;
            Console.WriteLine("Your number plus 25 = " + num4);
            Console.ReadLine();

            //Takes an input from user and divides it by 12.5
            Console.WriteLine("Please enter another number:");
            string num3entry = Console.ReadLine();
            double num5 = Convert.ToInt64(num3entry);
            double num6 = num5 / 12.5;
            Console.WriteLine("Your number divided by 12.5 = " + num6);
            Console.ReadLine();

            //Takes an input from user and checks if it is greater than 50
            Console.WriteLine("Please enter another number:");
            string num4entry = Console.ReadLine();
            long num7 = Convert.ToInt64(num4entry);
            bool trueOrFalse = num7 > 50;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            //Takes an input from user, divides it by 7, then prints the remainder
            Console.WriteLine("Please enter another number:");
            string num5entry = Console.ReadLine();
            long num8 = Convert.ToInt64(num5entry);
            long remainder = num8 % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating the myMath method
            myMath mymath = new myMath();

            //Asking user to enter two numbers, or possibly only one
            Console.WriteLine("Please enter a number.");
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You can enter another number if you like, or you can press enter.");

            //try/catch block to keep the program running if the user chooses not to enter a second number
            try
            {
                //Passing in 2 paramenters to myMath method if the user enters 2 numbers
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                int result1 = mymath.Addition(userNum1, userNum2);
                Console.WriteLine("The sum of your numbers + 125 = " + result1);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                //Passing in 1 parameter to myMath method if the user enters 1 number
                int result2 = mymath.Addition(userNum1);
                Console.WriteLine("The sum of your number + 125 = " + result2);
                Console.ReadLine();
            }
        }
    }
}

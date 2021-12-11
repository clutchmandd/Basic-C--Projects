using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMathMethodsApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number you would like to do a few math operations on.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //Passing in parameter of userNumber to MyMath Addition method
            int result1 = MyMath.Addition(userNumber);

            //Passing in parameter of userNumber to MyMath Subtraction method
            int result2 = MyMath.Subraction(userNumber);

            //Passing in parameter of userNumber to MyMath Addition method
            int result3 = MyMath.Multiplication(userNumber);

            //Displaying the returned integer results
            Console.WriteLine("Your number + 5 = " + result1);
            Console.WriteLine("Your number - 5 = " + result2);
            Console.WriteLine("Your number x 5 = " + result3);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating myMath method and calling on results
            myMath mymath = new myMath();

            int result1 = mymath.Addition();

            int result2 = mymath.Subtraction();

            int result3 = mymath.Multiplication();

            //Displaying resulting integers to the console
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}

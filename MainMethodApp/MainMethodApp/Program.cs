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

            //Passing in parameters to myMath method
            int result1 = mymath.myMethod(5);
            int result2 = mymath.myMethod(4.5);
            int result3 = mymath.myMethod("10");

            //Displaying resulting integers to the console
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();
        }
    }
}

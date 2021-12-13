using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodApp
{
    public class myMath
    {
        //Creating methods in the class myMath with parameters to return an integer to the Main method
        public int Addition(int num1 = 3)
        {
            return num1 + 5;
        }
        //Declaring a decimal parameter and converting it to an integer to return an integer
        public int Subtraction(double num2 = 4.5)
        {
            int num3 = Convert.ToInt32(num2);
            return num3 - 1;
        }
        //Declaring a string parameter and converting it to an integer to return an integer
        public int Multiplication(string num4 = "10")
        {
            int num5 = Convert.ToInt32(num4);
            return num5 * 10;
        }

    }
}

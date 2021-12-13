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
        public int myMethod(int num1)
        {
            return num1 + 5;
        }
        //Declaring a decimal parameter and converting it to an integer to return an integer
        public int myMethod(double num2)
        {
            int num3 = Convert.ToInt32(num2);
            return num3 - 1;
        }
        //Declaring a string parameter and converting it to an integer to return an integer
        public int myMethod(string num4)
        {
            int num5 = Convert.ToInt32(num4);
            return num5 * 10;
        }

    }
}

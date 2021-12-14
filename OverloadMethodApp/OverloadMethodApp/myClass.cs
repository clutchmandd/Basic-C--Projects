using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodApp
{
    public class myClass
    {
        //Creating a void method that outputs the user's integer divided by 2
        public void divideMethod(int num1)
        {
            int result = num1 / 2;
            Console.WriteLine("Your number divided by 2 = " + result);
            Console.ReadLine();
        }

        //Overloading the divideMethod
        public void divideMethod(int num2, int num3)
        {
            int result = num2 * num3;
            Console.WriteLine("Your number multiplied by 5 = " + result);
            Console.ReadLine();
        }

        //Creating an overloaded method with output parameters
        public void getValue(out int x)
        {
            int temp = 10;
            x = temp;
        }
        //public int getValue(out int y)
        //{
        //    y = 20;
        //    return y;
        //}
    }
    //Creating a static class
    public static class Add
    {
        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

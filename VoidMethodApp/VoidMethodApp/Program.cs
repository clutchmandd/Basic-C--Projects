using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating myMethod
            myClass myAdditionObject = new myClass();
            int num1 = 10;
            int num2 = 5;

            myAdditionObject.myMethod(num1, num2);
        }
    }
}

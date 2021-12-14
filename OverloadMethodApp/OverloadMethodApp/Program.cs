using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //Instantiating myClass and passing in the user's input to a void method that outputs an integer
            myClass myDivisionObject = new myClass();
            myDivisionObject.divideMethod(userNumber);

            //Displaying the output integer of the overloaded void method
            myDivisionObject.divideMethod(userNumber, 5);

            //Defining a local variable
            int a = 100;

            Console.WriteLine("Before getValue method is called, a = {0}", a);
            Console.ReadLine();
            
            //Retreiving the output parameter of the getValue method
            myDivisionObject.getValue(out a);
            Console.WriteLine("After the getValue method is called, a = {0}", a);
            Console.ReadLine();

            //Calling static Class and passing in parameters
            int result = Add.Sum(10, 25);
            Console.WriteLine("Using a static class, 10 + 25 = {0}", result);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariableApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating a new object of Employee
            Employee emp1 = new Employee("Jessica", "Dixon");

            //Creating a constant variable
            const string name = "David";
            Console.WriteLine("Hello, my name is {0}, and it is stored as a constant.", name);

            //Creating a var variable
            var myList = new List<string>() { "apples", "oranges", "bananas" };
            Console.WriteLine(myList.Contains("apples"));
            Console.ReadLine();
        }
    }
}

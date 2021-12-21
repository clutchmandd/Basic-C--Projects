using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstVariableApp
{
    public class Employee
    {
        //Creating a constructor
        public Employee()
        {
            Console.WriteLine("Constructor");
        }
        //Creating a chained constructor
        public Employee(string fName) : this()
        {
            Console.WriteLine("Chained Constructor");
        }
        //Creating another chained constructor
        public Employee(string fName, string lName) : this("David")
        {
            Console.WriteLine("Another Chained Constructor");
        }
    }
}

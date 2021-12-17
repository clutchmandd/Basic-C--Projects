using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsApp
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            //Instiating and initializing an Employee object
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";

            //Calling the superclass method that was inherited by the Employee class from the Person  class 
            employee.SayName();
            Console.ReadLine();
        }
    }
}

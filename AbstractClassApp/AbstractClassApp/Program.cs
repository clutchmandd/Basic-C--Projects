using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an employee object and passing in variables
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //Calling the SayName method that was inhereted from the abstract class
            employee.SayName();
            Console.ReadLine();
        }
    }
}

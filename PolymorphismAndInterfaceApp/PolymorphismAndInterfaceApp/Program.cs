using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating an employee object and passing in variables
            Employee employee = new Employee();
            employee.firstName = "Sample";
            employee.lastName = "Student";

            //Calling the Interface method Quit()
            employee.Quit(employee);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComparisonApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating the class Employee with 2 objects
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            //Declaring employee Id
            employee1.Id = 5;
            employee2.Id = 5;

            //Retreiving the correct return of the 2 bool methods
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}

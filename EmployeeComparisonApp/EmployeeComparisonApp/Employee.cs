using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComparisonApp
{
    public class Employee
    {
        //Getting the Id properties
        public int Id { get; set; }

        //Using 2 bool methods to overload the operators and find out if the 2 Employee objects are equal
        public static bool operator == (Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator != (Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
    }
}

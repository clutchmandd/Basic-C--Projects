using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressionApp
{
    public class Program
    { 
        public static void Main(string[] args)
        {
            //Creating 10 employees in the Employee class
            Employee employee1 = new Employee();
            {
                employee1.firstName = "David";
                employee1.lastName = "Dixon";
                employee1.Id = 1;
            }
            Employee employee2 = new Employee();
            {
                employee2.firstName = "Jessica";
                employee2.lastName = "Romans";
                employee2.Id = 2;
            }
            Employee employee3 = new Employee();
            {
                employee3.firstName = "Michael";
                employee3.lastName = "Jordan";
                employee3.Id = 3;
            }
            Employee employee4 = new Employee();
            {
                employee4.firstName = "Joe";
                employee4.lastName = "Rogan";
                employee4.Id = 4;
            }
            Employee employee5 = new Employee();
            {
                employee5.firstName = "Scottie";
                employee5.lastName = "Pippen";
                employee5.Id = 5;
            }
            Employee employee6 = new Employee();
            {
                employee6.firstName = "Steve";
                employee6.lastName = "Kerr";
                employee6.Id = 6;
            }
            Employee employee7 = new Employee();
            {
                employee7.firstName = "Steph";
                employee7.lastName = "Curry";
                employee7.Id = 7;
            }
            Employee employee8 = new Employee();
            {
                employee8.firstName = "Magic";
                employee8.lastName = "Johnson";
                employee8.Id = 8;
            }
            Employee employee9 = new Employee();
            {
                employee9.firstName = "Karl";
                employee9.lastName = "Malone";
                employee9.Id = 9;
            }
            Employee employee10 = new Employee();
            {
                employee10.firstName = "Joe";
                employee10.lastName = "Lewis";
                employee10.Id = 10;
            }

            //Creating a list of Employees and adding all employees from the Employee class
            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);
            employees.Add(employee3);
            employees.Add(employee4);
            employees.Add(employee5);
            employees.Add(employee6);
            employees.Add(employee7);
            employees.Add(employee8);
            employees.Add(employee9);
            employees.Add(employee10);

            //Using a foreach loop to print all employees with the first name Joe
            //foreach (Employee joe in employees)
            //{
            //    if (joe.firstName == "Joe")
            //    {
            //        List<Employee> joeList = new List<Employee>();
            //        joeList.Add(joe);
            //        for (int i = 0; i < joeList.Count; i++)
            //        {
            //            Employee joeEmployee = joeList[i];
            //            Console.WriteLine(joeEmployee.firstName + " " + joeEmployee.lastName);
            //        }
            //    }
            //}

            //Using a lambda expression to print all employees with the first name Joe
            List<Employee> joeList = employees.Where(x => x.firstName == "Joe").ToList();
            foreach (var joe in joeList)
            {
                Console.WriteLine(joe.firstName + " " + joe.lastName);
            }
            Console.ReadLine();

            //Using a lambda expression to print all employees with an Id number greater than 5
            List<Employee> IdAbove5List = employees.Where(x => x.Id > 5).ToList();
            foreach (var id5 in IdAbove5List)
            {
                Console.WriteLine(id5.firstName + " " + id5.lastName);
            }
            Console.ReadLine();
        }
    }
}

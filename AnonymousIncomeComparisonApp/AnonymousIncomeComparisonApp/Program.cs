using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparisonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //User 1 inputs hourly pay rate and hours worked per week
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Please enter your hourly pay rate:");
            string hourlyRate1entry = Console.ReadLine();
            double hourlyRate1 = Convert.ToDouble(hourlyRate1entry);
            Console.ReadLine();
            Console.WriteLine("Please enter your hours worked per week:");
            string hoursWorked1entry = Console.ReadLine();
            double hoursWorked1 = Convert.ToDouble(hoursWorked1entry);
            Console.ReadLine();

            //User 2 inputs hourly pay rate and hours worked per week
            Console.WriteLine("Person 2");
            Console.WriteLine("Please enter your hourly pay rate:");
            string hourlyRate2entry = Console.ReadLine();
            double hourlyRate2 = Convert.ToDouble(hourlyRate2entry);
            Console.ReadLine();
            Console.WriteLine("Please enter your hours worked per week:");
            string hoursWorked2entry = Console.ReadLine();
            double hoursWorked2 = Convert.ToDouble(hoursWorked2entry);
            Console.ReadLine();

            //Print annual salary of Person 1
            Console.WriteLine("The annual salary of Person 1 is:");
            double annualSalary1 = hourlyRate1 * hoursWorked1 * 52;
            Console.WriteLine(annualSalary1);
            Console.ReadLine();

            //Print annual salary of Person 2
            Console.WriteLine("The annual salary of Person 2 is:");
            double annualSalary2 = hourlyRate2 * hoursWorked2 * 52;
            Console.WriteLine(annualSalary2);
            Console.ReadLine();

            //Print if Person 1 makes more money than person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool trueOrFalse = annualSalary1 > annualSalary2;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
        }
    }
}

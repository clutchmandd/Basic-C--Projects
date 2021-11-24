using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranseApprovalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Saving user's input of age as an integer variable
            Console.WriteLine("What is your age?");
            string ageEntry = Console.ReadLine();
            int age = Convert.ToInt32(ageEntry);
            Console.ReadLine();

            //Saving user's input of DUI history as a boolean variable
            Console.WriteLine("Have you ever had a DUI? Please answer true or false");
            string duiEntry = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiEntry);
            Console.ReadLine();

            //Saving user's input of speeding tickets as an integer variable
            Console.WriteLine("How many speeding tickets do you have?");
            string ticketsEntry = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsEntry);
            Console.ReadLine();

            //Verifying if the user qualifies for car insurance
            Console.WriteLine("Qualified?");
            Console.WriteLine(age > 15 && dui == false && tickets <= 3);
            Console.ReadLine();
        }
    }
}

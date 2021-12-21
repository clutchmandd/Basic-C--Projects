using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace DateTimeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a variable of the current time and printing it
            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.ReadLine();

            //Receiving a number from the user to add to the current time
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            //Adding the user's input (in hours) to the current time and printing it
            var updated = now.AddHours(userNum);
            Console.WriteLine("The current time plus your number (in hours) = " + updated);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsApp
{
    public class Program
    {
        //Creating an Enum for Days of the Week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public static void Main(string[] args)
        {
            //Instantiating enum and retreiving user input
            DaysOfTheWeek day;
            Console.WriteLine("Please enter the current day of the week.");
            string userDay = Console.ReadLine();

            //Using try/catch block to parse through the enum and make sure the user input an actual day of the week
            try
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userDay);
                Console.WriteLine("You entered " + userDay);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            Console.ReadLine();
            
        }
    }
}

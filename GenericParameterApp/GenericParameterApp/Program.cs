using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameterApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Instantiating an Employee object with a string type as its generic parameter, and assinging a list of strings
            Employee<string> strThings = new Employee<string>();
            List<string> stringList = new List<string>() { "badge", "vest", "shoes" };
            strThings.things = stringList;

            //Instantiating an Employee object with an int type as its generic parameter, and assinging a list of integers
            Employee<int> intThings = new Employee<int>();
            List<int> intList = new List<int>() { 1, 2, 3 };
            intThings.things = intList;

            //Creating a loop to print the list of strings to the console
            for (int i = 0; i < strThings.things.Count; i++)
            {
                Console.WriteLine(stringList[i]);
            }

            //Creating a loop to print the list of integers to the console
            for (int t = 0; t < intThings.things.Count; t++)
            {
                Console.WriteLine(intList[t]);
            }
            Console.ReadLine();
        }
    }
}

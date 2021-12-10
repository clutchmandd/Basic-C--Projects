using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        //Starting the try/catch block
        try
        {
            //Creating a list of integers to divide by the number the user inputs
            List<int> numbers = new List<int>() { 8, 20, 60, 100 };

            Console.WriteLine("Please enter a number to divide each number in the list by.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            //For loop to iterate through the list and divide each number by userNumber
            for (int n = 0; n < numbers.Count; n++)
            {
                int results = numbers[n] / userNumber;
                Console.WriteLine(results);
            }
            Console.WriteLine("Here are the results of each number in the list divided by your number.");
            Console.ReadLine();
        }
        //Catch if user enters zero
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //Catch if user enters a string
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
        }
        //Printing that the program has finished the try/catch block and continuing to execute
        finally
        {
            Console.WriteLine("The program has emerged from the try/catch block and continued on with program execution.");
            Console.ReadLine();
        }
    }
}

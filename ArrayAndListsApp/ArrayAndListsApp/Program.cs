using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        string[] strArray = { "apples", "bananas", "peaches", "oranges" };

        int[] numArray = { 220, 5550, 623, 2325 };

        List<string> strList = new List<string>();
        strList.Add("Michael Jordan");
        strList.Add("Scottie Pippen");
        strList.Add("Dennis Rodman");
        strList.Add("Steve Kerr");

        //Receiving index from user to display from the array of strings
        Console.WriteLine("Please select an index of the array of strings:");
        int strInput = Convert.ToInt32(Console.ReadLine());

        if (strInput == 0 || strInput == 1 || strInput == 2 || strInput ==3)
        {
            Console.WriteLine(strArray[strInput]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That index does not exist. Try entering a number between 0 and 3.");
            int strInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(strArray[strInput1]);
        }
        Console.ReadLine();

        //Receiving index from user to display from the array of integers
        Console.WriteLine("Please select an index of the array of integers:");
        int intInput = Convert.ToInt32(Console.ReadLine());

        if (intInput == 0 || intInput == 1 || intInput == 2 || intInput == 3)
        {
            Console.WriteLine(numArray[intInput]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That index does not exist. Try entering a number between 0 and 3.");
            int intInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numArray[intInput1]);
        }
        Console.ReadLine();

        //Receiving index from user to display from the list of strings
        Console.WriteLine("Please select an index of the list of strings:");
        int lstInput = Convert.ToInt32(Console.ReadLine());

        if (lstInput == 0 || lstInput == 1 || lstInput == 2 || lstInput == 3)
        {
            Console.WriteLine(strList[lstInput]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That index does not exist. Try entering a number between 0 and 3.");
            int lstInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(strList[lstInput1]);
        }
        Console.ReadLine();
    }
}

using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string[] names = { "David", "Jessica", "Jonah", "Samuel" };

        Console.WriteLine("Please enter an action or verb (for example \"jumped\" or \"ran\"):");
        string userText = Console.ReadLine();

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i] + " " + userText + ".");
        }
        Console.ReadLine();


        //Creating an infinite loop and then fixing it
        //while (true) <-- infinite loop
        for (int b = 0; b <= 10; b++)  //<-- fixed to only write statement 10 times
        {
            Console.WriteLine("I am almost a Software Developer!");
        }
        Console.ReadLine();


        //Loop using < operator
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();

        //Loop using <= operator
        for (int i = 0; i <= 3; i++)
        {
            Console.WriteLine(names[i]);
        }
        Console.ReadLine();


        List<string> vehicles = new List<string>() { "sedan", "coupe", "suv", "truck" };

        Console.WriteLine("Please enter a type of vehicle to search for in the list:");
        string userVehicle = Console.ReadLine();
        bool isVehiclePresent = vehicles.Contains(userVehicle);

        if (isVehiclePresent == true)
        {
            int Index = vehicles.FindIndex(x => x.Contains(userVehicle));
            Console.WriteLine("Your input of " + userVehicle + " was found at index " + Index);
        }
        else
        {
            Console.WriteLine("Sorry, the vehicle type you entered is not in the list.");
        }
        Console.ReadLine();


        List<string> trees = new List<string> { "maple", "oak", "pine", "maple" };

        Console.WriteLine("Please enter a type of tree to search for in the list:");
        string userTree = Console.ReadLine();
        List<string> duplicateTrees = new List<string> { };

        for (int t = 0; t < trees.Count; t++)
        {
            if (userTree == trees[t])
            {
                Console.WriteLine("Your tree was found at index " + t);
            }
            else
            {
                Console.WriteLine("The tree you entered is not in the list.");
            }
        }
        Console.ReadLine();

        foreach (string tree in trees)
        { 
            if (duplicateTrees.Contains(tree))
            {
                Console.WriteLine("Your input of " + tree + " is a duplicate.");
            }
            else
            {
                Console.WriteLine("The tree you entered is not a duplicate.");
            }
            duplicateTrees.Add(tree);
        }
        Console.ReadLine();
    }
}

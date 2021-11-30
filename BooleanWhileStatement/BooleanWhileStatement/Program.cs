using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanWhileStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //while statement
            Console.WriteLine("Can you guess my name?");
            string nameGuessed = Console.ReadLine();
            bool guessed = nameGuessed == "David";

            while (!guessed)
            {
                switch (nameGuessed)
                {
                    case "Brian":
                        Console.WriteLine("You guessed Brian, and my name is not Brian. Try again.");
                        Console.WriteLine("Can you guess my name?");
                        nameGuessed = Console.ReadLine();
                        break;
                    case "Tim":
                        Console.WriteLine("You guessed Brian, and my name is not Brian. Try again.");
                        Console.WriteLine("Can you guess my name?");
                        nameGuessed = Console.ReadLine();
                        break;
                    case "David":
                        Console.WriteLine("Yes, my name is David. You're a great guesser!");
                        guessed = true;
                        break;
                    default:
                        Console.WriteLine("Nope. Not even close. Try again.");
                        Console.WriteLine("Can you guess my name?");
                        nameGuessed = Console.ReadLine();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}

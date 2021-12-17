using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsApp
{
    public class Person
    {
        //Creating properties for the class Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Creating a void method that write the person's full name to the console
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

    }
}

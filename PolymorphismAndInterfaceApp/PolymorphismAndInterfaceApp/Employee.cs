using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAndInterfaceApp
{
    //Creating an Employee class that inherets from the abstract class Person as well as the Interface IQuittable
    public class Employee : Person, IQuittable
    {
        //Implementing the virtual method that was inhereted from the abstract class
        public override void SayName()
        {
            base.SayName();
        }     
        //Creating an object of IQuittable
        public void Quit(Employee employee)
        {
            Console.WriteLine("Name: " + firstName + " " + lastName + " is quitting.");
        }
    }
}

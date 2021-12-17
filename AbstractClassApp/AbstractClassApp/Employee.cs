using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassApp
{
    //Creating an Employee class that inherets from the abstract class Person
    public class Employee : Person
    {
        //Implementing the virtual method that was inhereted from the abstract class
        public override void SayName()
        {
            base.SayName();
        }
    }
}

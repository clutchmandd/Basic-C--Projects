using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericParameterApp
{
    //Creating an Employee class with a generic type parameter
    public class Employee<T>
    {
        //Adding a generic list matching the generic type of the class
        public List<T> things { get; set; }
    }
}

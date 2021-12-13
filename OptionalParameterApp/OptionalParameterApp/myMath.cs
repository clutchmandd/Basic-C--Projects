using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterApp
{
    public class myMath
    {
        //Calling input parameter or parameters into a method to return a resulting integer
        public int Addition(int num1, int num2 = 0)
        {
            return num1 + num2 + 125;
        }
    }
}

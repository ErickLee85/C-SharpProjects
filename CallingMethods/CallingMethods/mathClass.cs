using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class mathClass //name of class
    {
        public static decimal Multiply(decimal methodOne) //parameter for this method, but will become argument with theAnswer variable when called 
        {
            return  methodOne * 10;
        }
       public static decimal Division(decimal methodTwo) 
        {
            return methodTwo / 10;
        }

        public static decimal Subtraction(decimal methodThree) 
        {
            return methodThree - 10;
        }
    }
}

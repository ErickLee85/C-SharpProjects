using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class mathClass //name of class
    {
        public static int Multiply(int methodOne) //parameter for this method, but will become argument with theAnswer variable when called 
        {
            return  methodOne * 10;
        }
       public static int Division(int methodTwo) 
        {
            return methodTwo / 10;
        }

        public static int Subtraction(int methodThree) 
        {
            return methodThree - 10;
        }
    }
}

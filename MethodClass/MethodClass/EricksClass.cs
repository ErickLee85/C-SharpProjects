using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodClass 
{
    public class ericksClass 
    {
        public void methodOne(int param1, int param2) //using void to say my method will not return a value
        {
            int mathOp = param1 - 50;
            Console.WriteLine(param1 + " - 50 = " + mathOp);
            Console.WriteLine("Parameter 2 = " + param2 + "\n");
            
            
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class ericksClass
    {
        public int methodOne(int first, int second = 5) //setting up two parameters, assigning default value to the second in the event it is not used(optional)
        {
            return first + second; //returning the sum of two arguments
            
        }
    }
}

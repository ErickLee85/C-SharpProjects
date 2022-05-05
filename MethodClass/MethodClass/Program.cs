using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ericksClass newObject = new ericksClass(); //instantiating new object from Class ericksClass

            newObject.methodOne(1000, 2000); //calling method by passing int arguments to methodOne of my class ericksClass

            int argument1 = 50;
            int argument2 = 100;

            
            newObject.methodOne(argument1, argument2); //calling method by passing in variables as arguments
            Console.ReadLine();
        }
    }
}

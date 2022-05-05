using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            mathClass theObject = new mathClass(); //instantiating class by creating new object "theObject" in order to gain access to the methods

            int firstResults = theObject.methodOne(100); //passing in integer as argument to methodOne
            Console.WriteLine(firstResults);

            int secondresults = theObject.methodOne(100.5m); //passing in decimal as argument to methodOne
            Console.WriteLine(secondresults);

            int thirdResults = theObject.methodOne("5"); //passing in string as argument to methodOne
            Console.WriteLine(thirdResults);
            Console.ReadLine();




            

        }
    }
}

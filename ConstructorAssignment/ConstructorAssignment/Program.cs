using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myPrimeNumber = 41; //integer constant, value can not be changed.

            Console.WriteLine($"{myPrimeNumber}");

            var myName = "Erick"; //using var here instead of starting syntax with "string myName"

            Console.WriteLine($"{myName}");

            Person obj1 = new Person(); //instantiating new Person object with no arguments.

            Console.WriteLine($"{obj1.fName} {obj1.lName}");

            Person obj2 = new Person("Erick", "Crowne"); //instantiating new Person object with two string arguments.
            Console.WriteLine($"{obj2.fName} {obj2.lName}");
            Console.ReadLine();

        }


    }
}


   

    

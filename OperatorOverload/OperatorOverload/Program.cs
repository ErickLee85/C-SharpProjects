using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Erick = new Employee(1, "erick"); //instantiating new Employee class objects
            Employee Jack = new Employee(3, "Jack");

            //Erick.Id = 1; //setting id's
            //Jack.Id = 3;

            Console.WriteLine($"Ericks Id: {Erick.Id}");
            Console.WriteLine($"Jacks Id: {Jack.Id}");

            Console.WriteLine($"Are Ids equal? {Erick == Jack}"); // checking boolean status of two objects
            Console.ReadLine();
        }
    }
}

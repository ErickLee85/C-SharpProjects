using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> myString = new Employee<string>();
            myString.things = new List<string> { "One", "Two", "Three" };
           

            foreach (string thang in myString.things)
            {
                Console.WriteLine(thang);
            }
        

            Employee<int> myInts = new Employee<int>();
            myInts.things = new List<int> { 1, 2, 3 };

            foreach (int thing in myInts.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();

        }
    }
}

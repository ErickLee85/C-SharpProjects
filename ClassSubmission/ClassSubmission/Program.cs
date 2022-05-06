using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ericksClass newObject = new ericksClass();   //instantiating new object from ericksClass

            Console.WriteLine("Enter a number: ");
            int usersNumber = Convert.ToInt32(Console.ReadLine());  //casting users input from string to integer!
            newObject.methodOne(usersNumber);   //calling first methodOne with single variable

            string b;    //initiliazing string variable but not giving it a value
            newObject.outMethod(out b);  //calling output parameter from outMethod
            Console.WriteLine($"The value of the out Parameter is {b}");

            newObject.methodOne(450, 500);   //overloading same methodOne with 2 arguments








            Console.ReadLine();
        }
    }
}

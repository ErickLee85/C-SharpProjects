using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            ericksClass theOjbect = new ericksClass(); //creating new object from Class ericksClass 
            Console.WriteLine("Enter two numbers, one at a time.\nFirst choice: "); 
            int firstNumber = Convert.ToInt32(Console.ReadLine()); //casting string to integer


            Console.WriteLine("Second choice is optional: ");

            try
            {
                //utilizing try block in the event user puts in 2 arguments

                int secondNumber = Convert.ToInt32(Console.ReadLine());

                int firstTry = theOjbect.methodOne(firstNumber, secondNumber); //using new object to call methodOne and putting in multiple arguments
                Console.WriteLine(firstNumber + " + " + secondNumber + " = " + firstTry );
                Console.ReadLine();
            }

            catch
            {
                //catch block for single argument from user

                int secondTry = theOjbect.methodOne(firstNumber);
                Console.WriteLine(firstNumber + " + 5 " + " = " + secondTry);
                Console.ReadLine();
            }

    
        }
    }
}

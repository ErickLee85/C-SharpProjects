using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryTimes = 0;
            while (tryTimes < 3)//creating a short loop if user inputs wrong data type, the user will be able to retry automatically or just do more math operations if he/she chooses
            {
                try
                {
                    Console.WriteLine("Enter any number to do some math operations on using a Math class and 3 different Methods!");
                    int theAnswer = Convert.ToInt32(Console.ReadLine()); //casting users input into an integer

                    int firstAnswer = mathClass.Multiply(theAnswer); //defining int variable by calling the Class "mathClass" and the method "Multiply" and passing in the argument "theAnswer" to my Method

                    int secondAnswer = mathClass.Division(theAnswer);

                    int thirdAnswer = mathClass.Subtraction(theAnswer);

                    Console.WriteLine(theAnswer + " * 10 : " + firstAnswer +
                                      "\n" + theAnswer + " / 10: " + secondAnswer +
                                      "\n" + theAnswer + " - 10: " + thirdAnswer);
                    

                }

                catch (FormatException ex) //using this catch for data format error, incase user types in string instead of decimal or integer
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    tryTimes++;
                }
                
            }Console.ReadLine();

        }
        
    }
    
}

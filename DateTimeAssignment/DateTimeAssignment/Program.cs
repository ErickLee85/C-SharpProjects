using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime theDate = DateTime.Now; //instantiating new DateTime object
            Console.WriteLine($"The current date and time is: {theDate}"); //printing to console the value of theDate object

            Console.WriteLine("Enter a number: ");
            int userNum = Convert.ToInt32(Console.ReadLine()); //casting user input to integer

            DateTime newTime = new DateTime(); //instantiating new DateTime object
            newTime = theDate.AddHours(userNum); //Adding in hours to current date
            Console.WriteLine($"The current time plus your number input is: \n{newTime}"); //print newTime object to screen
            Console.ReadLine();
        }
    }
}

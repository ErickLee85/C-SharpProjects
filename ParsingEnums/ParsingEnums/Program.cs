using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        enum DaysOfTheWeek //creating enum
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main()
        {
            Console.WriteLine("What is the current day of the week?");
            string value = Console.ReadLine();
            DaysOfTheWeek day; //instantiating enum object
            try             //TRY CATCH BLOCK
            {
                day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), value); //if this statement is true...
                Console.WriteLine($"{value}, now thats a good day.");
                Console.ReadLine();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package in pounds?");
            decimal packageWeight = Convert.ToDecimal(Console.ReadLine()); //Casting string to decimal for maths
            if (packageWeight > 50) //Conditional statement to be tested
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");//if boolean is true, this line is executed.
                    Console.ReadLine();
            }
            else //if boolean is false, do this 
            {
                Console.WriteLine("What is the width of your package?");
                decimal packageWidth = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("What is the height of your package?");
                decimal packageHeight = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("What is the length of your package?");
                decimal packageLength = Convert.ToDecimal(Console.ReadLine());

                decimal dimensions = packageWidth + packageHeight + packageLength;

                if (dimensions > 50)//An additional if statement inside an else statement, testing for another boolean
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    decimal costQuote = packageWidth * packageHeight * packageLength * packageWeight / 100; //formula to calculate shipping cost!
                    Console.WriteLine("Your estimated total for shipping this package is: $" + costQuote.ToString() + "\nThank you!");
                    Console.Read();
                }
            }
        }
    }
}

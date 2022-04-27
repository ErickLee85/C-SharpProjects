using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            string firstLine = Console.ReadLine();
            int num1 = Convert.ToInt32(firstLine);
            int total = num1 * 50;
            Console.WriteLine("Your number * 50 is: " + total.ToString());
            Console.WriteLine("Enter any number");
            string secondLine = Console.ReadLine();
            int num2 = Convert.ToInt32(secondLine);
            int addTotal = num2 + 25;
            Console.WriteLine("Your Number + 25 is: " + addTotal.ToString());
            Console.WriteLine("Enter any number");
            string thirdLine = Console.ReadLine();
            decimal num3m = Convert.ToDecimal(thirdLine);
            decimal thirdTotal = num3m / 12.5m;
            Console.WriteLine("Your number divided by 12.5 is: " + thirdTotal.ToString());
            Console.WriteLine("Enter any number");
            string fourthLine = Console.ReadLine();
            int num4 = Convert.ToInt32(fourthLine);
            bool trueOrFalse = num4 > 50;
            Console.WriteLine("Is your number greater than 50? " + trueOrFalse.ToString());
            Console.WriteLine("Enter any number");
            string fifthLine = Console.ReadLine();
            int num5 = Convert.ToInt32(fifthLine);
            int remainder = num5 % 7;
            Console.WriteLine("Your number didvided by 7 has a remainder of: " + remainder.ToString());
            Console.Read();


        }
    }
}

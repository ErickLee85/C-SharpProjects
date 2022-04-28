using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");

            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            int user1Age = Convert.ToInt32(userAge);//Casting string to int data type

            Console.WriteLine("Have you ever had a dui? Enter \"true\" or \"false\" ");// using back slashes as escape characters for double quotes
            string dui = Console.ReadLine();
            bool user1Dui = Convert.ToBoolean(dui);//Casting string to boolean value

            Console.WriteLine("How many speeding tickets do you have?");
            string tickets = Console.ReadLine();
            int user1Tickets = Convert.ToInt32(tickets);//Casting string to int data type

            bool qualifications = (user1Age > 15 && user1Dui == false && user1Tickets <= 3); //Boolean conditional statements using &&, every condition must be true

            Console.WriteLine("Qualified? \n" + qualifications);
            Console.Read();
        }
    }
}

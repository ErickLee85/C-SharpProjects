using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");


            Console.WriteLine("Person 1:"); //Person 1 block
            Console.WriteLine("Enter Hourly Rate: ");
            string user1Pay = Console.ReadLine(); //setting variable to Person 1 input
            decimal user1PayRate = Convert.ToDecimal(user1Pay); //Casting string to decimal, I chose decimal instead of int in the event hourly pay or hours worked is not a whole number.
            Console.WriteLine("Enter Hours worked per week: ");
            string user1Hours = Console.ReadLine();
            decimal user1WeeklyHours = Convert.ToDecimal(user1Hours);


            Console.WriteLine("Person 2:"); //Person 2 block
            Console.WriteLine("Enter Hourly Rate: ");
            string user2Pay = Console.ReadLine();
            decimal user2PayRate = Convert.ToDecimal(user2Pay);
            Console.WriteLine("Enter Hours worked per week: ");
            string user2Hours = Console.ReadLine();
            decimal user2WeeklyHours = Convert.ToDecimal(user2Hours);


            decimal user1Salary = user1PayRate * user1WeeklyHours * 52; //Calculating salary with decimal data type for variable, 52 represents number of weeks per year.
            Console.WriteLine("Annual Salary of Person 1: " + user1Salary.ToString());


            decimal user2Salary = user2PayRate * user2WeeklyHours * 52;
            Console.WriteLine("Annual Salary of Person 2: " + user2Salary.ToString());


            bool salaryComparison = user1Salary > user2Salary;
            if (salaryComparison == true) //Using boolean logic for conditional statement
            { 
                Console.WriteLine("Does Person 1 make more money than Person 2? " + "Yes");
            }
            else
            {
                Console.WriteLine("Does Person 1 make more money than Person 2? " + "No");
            }
            Console.Read();
                
            
        }
    }
}

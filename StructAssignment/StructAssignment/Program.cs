using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{
    public struct Number //Creating a struct (value type) called NUmber
    {
        public decimal Amount; //setting property to decimal type 
       
    }
    class Program
    {
        static void Main(string[] args)
        { 


            Number number = new Number(); //instantiating object of struct

            number.Amount = 500; //setting value to property

            Console.WriteLine($"The value of Amount in the struct Number is {number.Amount}."); //printing value to screen
            Console.ReadLine();


        }
    }
}

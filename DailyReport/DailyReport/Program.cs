using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //Console.WriteLine will print the text in "" to the cmd prompt
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine(); //Console.ReadLine() takes in the user input and stores it in the variable StudentName
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int newPage = Convert.ToInt32(pageNumber); //Here we are converting string from user input into an integer to perhaps maybe do math with at a later time.
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\""); //Using \escape characters to insert double quotes inside a double quote.
            string needHelp = Console.ReadLine();
            bool studyHelp = Convert.ToBoolean(needHelp); //Converting string to boolean value
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experience = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            int studyHours = Convert.ToInt32(hours); //Converting string text from user input into integer data type.
            Console.WriteLine("THank you for your answers. An instructor will respond to this shortly.\nHave a great day!");
            Console.ReadLine(); //This line will leave cmd prompt open until user manually exits program, otherwise cmd prompt by default exits after every line of code has ran.



            
        }
    }
}

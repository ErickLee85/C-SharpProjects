using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animal = { "Elephant", "Jaguar", "Eagle", "Jellyfish", "Gecko" }; //creating an array of strings.
            Console.WriteLine("Enter any word that is an adjective: ");
            string userInput = Console.ReadLine(); //assigning user input to string variable userInput.

            for (int i = 0; i < animal.Length; i++) //for loop to iterate through array and append userInput string.
            {
                Console.WriteLine("The " + animal[i] + " is " + userInput + ".");

            }

            bool isItTrue = true;

            while (isItTrue) //Creating infinite loop
            {
                Console.WriteLine("This is/was an infinite loop.");
                isItTrue = false; //breaking infinite loop              
            }

            for (int i = 0; i < 5; i++) //for loop using < operator
            {
                Console.WriteLine("I love C#");
            }

            for (int i = 0; i <= 5; i++) //for loop using <= operator
            {
                Console.WriteLine("I still love C#");
            }
        

            List<string> names = new List<string>() { "Erick", "Carl", "Elon", "Isaac", "John", "David", "Bob", "Jackie", "Elizabeth", "Phil" }; //creating a list of strings 
            Console.WriteLine("Enter a name to search for in my list.");
            string search = Console.ReadLine();
            int index = names.IndexOf(search); //finding index of element based off user input
            bool isNameThere = names.Contains(search);//creating boolean to run code if users inputted name exists in list

            if (isNameThere) //if boolean = true
            {
                Console.WriteLine(String.Format("The Element {0} is found at index {1}", search, index)); //formatting string to display element and index. Sort of like Pythons syntax
            }
            else
            {
                Console.WriteLine("Name not spelled correctly or is not in list.");
            }

            List<string> rainbow = new List<string>() { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet", "Orange" };

            Console.WriteLine("Pick your favorite color from the rainbow");
            string favColor = Console.ReadLine();
            int myIndex = rainbow.IndexOf(favColor);
            bool trueOrFalse = rainbow.Contains(favColor);

            if (trueOrFalse)
            {
                Console.WriteLine(String.Format("The element {0} is found at index {1}", favColor, myIndex));
            }
            else
            {
                Console.WriteLine("This color does not exist in my list.");
            }
            

            List<string> Cars = new List<string>() { "Honda", "Acura", "Nissan", "Infinity", "Chevrolet", "Cadillac", "Honda", "Nissan", "Cadillac" };
            Console.WriteLine("List of Cars: ");
            foreach (string car in Cars)
            {
                Console.WriteLine(car);
            }
            IEnumerable<string> duplicates = Cars.GroupBy(x => x) //finding duplicate elements
                                 .SelectMany(g => g.Skip(1));

            Console.WriteLine("The Duplicate elements in my Car List are: " + String.Join(", ", duplicates)+ ".");

            Console.ReadLine();








        }
    }
}

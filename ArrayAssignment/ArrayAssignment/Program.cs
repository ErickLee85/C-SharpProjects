using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string[] strArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" }; //defining string array

        Console.WriteLine("Select an index of my string Color Array by choosing any number between 0 and 6");
        int answer = Convert.ToInt32(Console.ReadLine());//casting user string input into integer to use as an index for my array
        if (answer <= 6) //Conditional statement for error checking
        {
            Console.WriteLine("Value: " + strArray[answer]);         
        }
        else
        {
            Console.WriteLine("Error - Please enter any number between 0 and 6");
            int newAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value: " + strArray[newAnswer]);
        }

        int[] intArray = { 10, 100, 1000, 10000 }; //defining integer array

        Console.WriteLine("Select an index of my integer Array by choosing any number between 0 and 3");
        int intAnswer = Convert.ToInt32(Console.ReadLine());
        if (intAnswer <= 3)
        {
            Console.WriteLine("Value: " + intArray[intAnswer]);
        }
        else
        {
            Console.WriteLine("Error - Please enter any number between 0 and 3");
            int newIntAnswer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value: " + intArray[newIntAnswer]);
        }

        string[] Stars2 = { "Red Giant", "Blue SuperGiant", "Neutron", "White Dwarf", "Main Sequence" };//created this string array to populate my list faster
        List<string> Stars = new List<string>();//defining list
        Stars.AddRange(Stars2);//adding string array to list

        Console.WriteLine("Select an index of my Star-Type List by choosing any number between 0 and 4");
        int starIndex = Convert.ToInt32(Console.ReadLine());
        if (starIndex <= 4)
        {
            Console.WriteLine("Value: " + Stars[starIndex]);
        }
        else
        {
            Console.WriteLine("Error - Please enter any number between 0 and 3");
            int newStarIndex = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Value: " + Stars[newStarIndex]);
        }
        Console.Read();






    }
}
    


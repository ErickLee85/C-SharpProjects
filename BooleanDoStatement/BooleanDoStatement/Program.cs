using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanDoStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What planet in our Solar System has the fastest rotational speed?");
            Console.WriteLine("Choices:\n'Mercury'\n'Venus'\n'Earth'\n'Mars'\n'Jupiter'\n'Saturn'\n'Uranus'\n'Neptune'\n'Pluto'");
            string answer = Convert.ToString(Console.ReadLine());
            bool isGuessed = answer == "Jupiter"; //setting boolean value to true if answer is Jupiter

            do //execute a do statement to force program to run a switch loop in the event initial user input may prevent loop from running
            {
                switch (answer)
                {
                    case "Mercury":
                        Console.WriteLine("Mercury moves the fastest around the sun but it spins very slowly.");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Venus":
                        Console.WriteLine("Venus is the hottest, but not the fastest!");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Earth":
                        Console.WriteLine("It's not our planet!");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Mars":
                        Console.WriteLine("Mars' day is actually longer than Earths!");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Jupiter":
                        Console.WriteLine("Congratulations, you guessed it! A day on Jupiter is only 9 hours and 56 minutes!\nYet it's the biggest planet in the Solar System! You could fit 1300 Earths inside it.");
                        isGuessed = true;
                        break;
                    case "Saturn":
                        Console.WriteLine("You are so close... but this is still wrong");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Uranus":
                        Console.WriteLine("I know what you're thinking... wrong answer though.");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Neptune":
                        Console.WriteLine("Nope! Not Neptune! Keep guessing.");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    case "Pluto":
                        Console.WriteLine("Pluto isn't even a planet, man! ");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Please spell the name exactly how it is quoted.");
                        Console.WriteLine("Try again.");
                        answer = Convert.ToString(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);
            Console.Read();
        }
    }
}

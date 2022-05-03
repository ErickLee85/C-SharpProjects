using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> ericksList = new List<int>() { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; //list of integers
                Console.WriteLine("Enter any number to be divided by each number in my list.");
                int usersNumber = Convert.ToInt32(Console.ReadLine()); //converting users input to integer 

                for (int i = 0; i < ericksList.Count; i++) //creating for loop to iterate through each element of my list so i can perform math formulas.
                {
                    int theAnswer = ericksList[i] / usersNumber;
                    Console.WriteLine(ericksList[i] + " / " + usersNumber + " = " + theAnswer);
                }
            }
            catch (FormatException ex) //catches wrong data format ie: string instead of integer
            {

                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex) //catches if user attempts to divide by zero 
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) //general exception 
            {
                Console.WriteLine(ex.Message);
            }
            finally //this line runs regardless of catch block.
            {
                Console.WriteLine("Program running.");
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchException
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine("Please enter your age: \n");


            try
            {
                int usersAge = Convert.ToInt32(Console.ReadLine());

                if (usersAge <= 0)
                {
                    throw new ExceptionHandling();
                }

                var usersBirthday = DateTime.Today.AddYears(-usersAge);

                Console.WriteLine(${usersBirthday}");
                Console.Read();
            }
            catch (ExceptionHandling)
            {
                Console.WriteLine("Please enter a positive whole number.");
                Console.ReadLine();
               
            
            }

            catch (Exception)
            {
                Console.WriteLine("An error occured.");
                Console.ReadLine();
                
               
            }

       
            

            


           



            




 
        }
    }
}

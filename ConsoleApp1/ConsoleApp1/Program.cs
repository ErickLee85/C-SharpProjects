using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite prime number!");
            int primeNumber = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter myFile = new StreamWriter(@"C:\Users\erick\OneDrive\Desktop\log1.txt", true))
            {
                myFile.WriteLine(primeNumber);
                
            }
            string line;
            using (StreamReader theFile = new StreamReader(@"C:\Users\erick\OneDrive\Desktop\log1.txt", true))
            {
                line = theFile.ReadLine();
                while (line !=null)
                {
                    Console.WriteLine(line);
                    line = theFile.ReadLine();                       
                }
            

            }
            Console.Read();



        }
    }
}

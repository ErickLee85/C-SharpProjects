using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndObjects
{
    public class Person
    {
        public string FirstName { get; set; } //defining property as string FirstName

        public string LastName { get; set; } //defining property as string LastName

        public void SayName() //void method with no parameters
        {
            Console.WriteLine($"Name : {FirstName} {LastName}.");
        }
    }


}

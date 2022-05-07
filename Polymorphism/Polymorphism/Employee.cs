using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Employee : Person, IQuittable //inheriting Person Class and IQuittable interface.
    {

        public override void SayName() //override keyword to access virtual method from Person class. Can also add more data inside {}
        {

            base.SayName(); //basically this syntax is just calling the sayName method from Person Class. 
        }

        public void Quit() //calling quit method from interface
        {
            Console.WriteLine("Are you sure you want to quit?");
            Console.ReadLine();
        }
    }
}


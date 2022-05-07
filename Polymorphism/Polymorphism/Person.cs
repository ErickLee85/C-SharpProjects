using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Person
    {
        public string firstName { get; set; } //firstName property
        public string lastName { get; set; } //lastName property

        public virtual void SayName() //virtual method to be used or over ridden from any class that inerhits it.
        {
            Console.WriteLine($"{firstName } { lastName}");
        }
    }
}

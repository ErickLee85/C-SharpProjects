using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Employee : Person //Employee Class inheriting from abstract class Person
    {
        public override void SayName() //override keyword to access virtual method from Person class. Can also add more data inside {}
        {
            
            base.SayName(); //basically this syntax is just calling the sayName method from Person Class. 
        }
    }
}

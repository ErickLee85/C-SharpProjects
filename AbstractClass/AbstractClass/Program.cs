using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee(); //instantiating new object from Employee, you can not instantiate object from an Abstract class; eg: Person.
            newEmployee.firstName = "Sample";//adding string to property of Employee class
            newEmployee.lastName = "Student"; //adding string to property of Employee class
            newEmployee.SayName(); //calling inherited method 
            Console.ReadLine();
        }
    }
}

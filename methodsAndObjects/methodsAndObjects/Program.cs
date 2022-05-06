using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee(); //instantiating new object from Employee class
            newEmployee.FirstName = "Sample"; //Creating new instance of FirstName property
            newEmployee.LastName = "Student"; //Creating new isntance of LastName property

            newEmployee.SayName(); //calling superclass method from Person Class
            Console.ReadLine();
        }
    }
}

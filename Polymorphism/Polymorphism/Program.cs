using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee newEmployee = new Employee(); //instantiating new Employee object

            newEmployee.firstName = "Erick";
            newEmployee.lastName = "Crowne";
            newEmployee.SayName();

            newEmployee.Quit(); //calling inherited interface method Quit()
        }
    }
}

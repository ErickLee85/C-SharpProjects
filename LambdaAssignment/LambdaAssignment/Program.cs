using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> myList = new List<Employee>(); //instantiating new list of Employees

            myList.Add(new Employee()
            {
                ID = 1,
                firstName = "Erick",
                lastName = "Crowne"

            });
            myList.Add(new Employee()
            {
                ID = 2,
                firstName = "Joe",
                lastName = "Schmoe"

            });
            myList.Add(new Employee()
            {
                ID = 3,
                firstName = "Joe",
                lastName = "Rogan"

            });
            myList.Add(new Employee()
            {
                ID = 4,
                firstName = "Carl",
                lastName = "Sagan"

            });
            myList.Add(new Employee()
            {
                ID = 5,
                firstName = "Arnold",
                lastName = "Schwarzenegger"

            });
            myList.Add(new Employee()
            {
                ID = 6,
                firstName = "Edmund",
                lastName = "Halley"

            });
            myList.Add(new Employee()
            {
                ID = 7,
                firstName = "Giordano",
                lastName = "Bruno"

            });
            myList.Add(new Employee()
            {
                ID = 8,
                firstName = "Isaac",
                lastName = "Newton"

            });
            myList.Add(new Employee()
            {
                ID = 9,
                firstName = "Larry",
                lastName = "Wheels"

            });
            myList.Add(new Employee()
            {
                ID = 10,
                firstName = "Robin",
                lastName = "Williams"

            });

            Console.WriteLine("This list of Employees named Joe was iterated by a foreach loop.");

            foreach (Employee name in myList) //foreach loop
            {
               if (name.firstName == "Joe") 
                {
                    List<Employee> joesList = new List<Employee>(); //new list for employees named joe
                    joesList.Add(name); //adding to joesList
                    foreach (Employee joe in joesList)
                    {
                        Console.WriteLine(joe.firstName + " " + joe.lastName);
                    }   
                }

            }
            

          

            List<Employee> lambdaMade = new List<Employee>();
            lambdaMade = myList.Where(x => x.firstName == "Joe").ToList(); //lambda function for Employees first name == Joe, added to lambdaMade list

            Console.WriteLine("This list was iterated via a lambda function for Employees named Joe");
            foreach (Employee person in lambdaMade)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }

            List<Employee> idBased = new List<Employee>();
            idBased = myList.Where(x => x.ID > 5).ToList(); //lambda function for Employees whos ID > 5, added to idBased list

            Console.WriteLine("This list was iterated by a lambda function for Employees whos ID number is > 5.");

            foreach (Employee person in idBased)
            {
                Console.WriteLine(person.firstName + " " + person.lastName);
            }
            Console.ReadLine();







        }
    }
}

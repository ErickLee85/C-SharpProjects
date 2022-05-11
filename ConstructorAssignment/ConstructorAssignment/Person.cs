using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        public Person() : this("John", "Doe") //First constructor, which will be called if no parameters are used for new instantiated object. John Doe will be the default name. "this" is referring back to constructor below
        {

        }

        public Person(string firstName, string lastName) //second constructor, which will be used if user passes in two string arguments to new object.
        {
            fName = firstName;
            lName = lastName;
        }

        public string fName { get; set; } //first name property
        public string lName { get; set; } //last name property


    }
}

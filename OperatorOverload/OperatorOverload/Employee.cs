using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverload
{
    public class Employee
    {
        public int Id { get; set; } //Id property

        public static bool operator == (Employee first, Employee second) //overloading bool operator == (true)
        {
            return first.Id == second.Id;
        }
        public static bool operator != (Employee first, Employee second) //overloading bool operator != (false)
        {
            return first.Id != second.Id;
        }
}
}

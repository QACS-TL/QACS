using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors1
{
    internal class Employee
    {
        public readonly string firstName;
        public readonly string lastName;
        public readonly int employeeID;

        public Employee()
        {
            firstName = "Anon";
        }

        public Employee(string firstName, string lastName, int employeeID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.employeeID = employeeID;
        }
    }
}

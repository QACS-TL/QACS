using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesAndConstructors
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeID { get; set; }

        public Employee(string firstname, string lastname, int employeeID)
        {
            FirstName = firstname;
            LastName = lastname;
            EmployeeID = employeeID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operators_Demo
{
    public class Employee
    {
        public string FirstName;       // define properties
        public string LastName;
        public int Id;

        public static bool operator== (Employee employee1, Employee employee2)     //define operator implementation, requiring two Employee objects with property Id
        {
            if (employee1.Id.Equals(employee2.Id))     // if the Id properties are the same return true
                return true;
            else
                return false;                          // else return false
        }
        public static bool operator!= (Employee employee1, Employee employee2)
        {
            if (employee1.Id.Equals(employee2.Id))     // define the same logic for the != operator, which is the negatory counterpart to ==
                return false;
            else
                return true;
        }
    }
}

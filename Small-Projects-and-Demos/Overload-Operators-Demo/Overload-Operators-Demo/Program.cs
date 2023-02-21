using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_Operators_Demo
{
    class Program
    {
        // Step 1: Create an Employee class with Id, FirstName, and LastName properties - See Employee.cs
        // Step 2: In the Employee class, overload the == operator so it checks if two Employee objects are equal by comparing their Id property.
        //  - see Employee.cs
        // Step 3: instantiate two Employee objects, assign property values, and compare them using the overloaded operators. Display results
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();     
            employee1.FirstName = "John";
            employee1.LastName = "Smith";
            employee1.Id = 2;

            Employee employee2 = new Employee();    // employee1 and employee2 have the same value for Id, and different values everywhere else.
            employee2.FirstName = "Jane";           // comparing with == should evaluate to True; with != should evaluate to False
            employee2.LastName = "Doe";
            employee2.Id = 2;

            Employee employee3 = new Employee();   // employee2 and employee3 have same values for FirstName and LastName, but different Id.
            employee3.FirstName = "Jane";          // comparing with == should evaluate to False; with != to True 
            employee3.LastName = "Doe";
            employee3.Id = 3;

            Console.WriteLine(employee1 == employee2);     
            Console.WriteLine(employee1 != employee2);
            Console.WriteLine(employee2 == employee3);
            Console.WriteLine(employee2 != employee3);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create a class called Person.cs, assign two string properties [FirstName] and [LastName] - see Person.cs
            // Step 2: Create a void method calle SayName() that takes no parameters and simply writes a Person's full name. - see Person.cs
            // Step 3: Create another class called Employee and have it inherit from the Person class.
            //          Give the Employee class a property called Id and have it be of data type int.      - See Employee.cs
            // Step 4: Inside of the Main method, instantiate and initialize an Employee object with
            //          a first name of “Sample” and a last name of “Student”.
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            // Step 5: Call the superclass method SayName() on the employee object
            employee.SayName();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Create an abstract class called Person with two properties: string firstName and string LastName - see Person.cs
            // Step 2: In Person.cs, create method called SayName() - See Person.cs
            // Step 3: Create another class called Employee and have it inherit from Person.cs - see Employee.cs
            // Step 4: Implement SayName() within Employee.cs - see Employee.cs
            // Step 5: Inside Main() method, instantiate Employee object with firstName = "Sample" and lastName = "Student"; call SayName on the object
            

            Employee employee = new Employee();      //instantiating from the child class, which inherited properties and a method from Person.cs
                                                     // Even though the inherited virtual method SayName() had no implemenation in the base class (Person.cs),
                                                     // the implementation can be defined in the child class (Employee.cs) as needed.

            employee.firstName = "Sample";
            employee.lastName = "Student";
            employee.SayName();
            Console.ReadLine();
        }
    }
}

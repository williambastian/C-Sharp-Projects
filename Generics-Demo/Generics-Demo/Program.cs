using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Generics_Demo
{
    // In C#, make a class called Employee that takes a generic type parameter.

    // Add a property to the Employee class called “Things” and have its data type be a generic list matching the generic type of the class.  - see Employee.cs

    // Instantiate an Employee object with type “string” as its generic parameter. Assign a list of strings as the property value of Things.

    // Instantiate an Employee object with type “int” as its generic parameter. Assign a list of integers as the property value of Things.

    // Create a loop that prints all of the Things to the Console.
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();    // instantiate Employee object with type string
            employee.Things = new List<string> { "thing1", "thing2", "thing3" };   // assign list of string values as property value of Things

            Employee<int> employee2 = new Employee<int>();    // instantiate Employee object with type int. Because the type parameter is generic, this object can accept a different data type without altering Employee.cs
            employee2.Things = new List<int> { 1, 2, 3 };

            foreach (string thing in employee.Things)   // create loop to print all "things"
            {
                Console.WriteLine(thing);
            }

            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();


        }
    }
}

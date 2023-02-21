using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism_Demo
{
    class Program
    {
        // Step 1 - Create interface called IQuittable and define a void method called Quit() - see IQuittable.cs
        // Step 2 - Have class Employee.cs inherit the interface IQuittable and implement the Quit() method with demonstration code
        // Step 3 - create an object of type IQuittable and call the Quit() method on it
        static void Main(string[] args)
        {
            IQuittable employee = new Employee();      // create object of type IQuittable
            employee.Quit();                           // call Quit() method. Employee.cs can inherit from an interface, similar to an abstract class
                                                       // objects can be of interface type if it implements that specific interface
            Console.ReadLine();

        }
    }
}

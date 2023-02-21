using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Demo
{
    public class Employee : Person    // inherits from Person.cs
    {
        public override void SayName()    // implements SayName() in Employee.cs.
                                          // the override is required when implementing an abstract method in a child class
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
            
        }
    }
}

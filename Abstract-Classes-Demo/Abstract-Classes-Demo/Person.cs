using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Demo
{
    public abstract class Person        // Person is an abstract class, which cannot be directly instantiated.
                                        // Only classes that inherit, and are not abstract, can be instantiated to use this class's functionality
    {
        public string firstName;
        public string lastName;

        public abstract void SayName();  // abstract method - implemented in Employee.cs
        
    }
}

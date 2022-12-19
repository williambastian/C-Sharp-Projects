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

        public virtual void SayName()  // virtual method - allows us to change implementation of this method depending on which class inherits it
                                       // for example, Employee.cs may have one implementation of SayName(), but another class, such as "Manager.cs" or "Executive.cs" could have a different implementation.
        {
           
        }
    }
}

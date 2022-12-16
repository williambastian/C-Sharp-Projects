using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Demo
{
    public class Person        // set class to public
    {
        public string FirstName;     //assign properties
        public string LastName;

        public void SayName()                                     // SayName() method includes instructions to format and write property values
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
        }

    }
}

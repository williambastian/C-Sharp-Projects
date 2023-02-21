using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Inheritance_Demo
{
    public class Employee : Person     //make class public, add name of superclass to establish inheritance
    {
        public int ID;     //   this property will be unique to the Employee class until another class is established to inherit from Employee.
                            // The properties and methods in the Person class will now be shared by the Employee class.
    }
}

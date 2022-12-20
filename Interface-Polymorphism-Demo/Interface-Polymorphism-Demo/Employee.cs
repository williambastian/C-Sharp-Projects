using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Polymorphism_Demo
{
    public class Employee : IQuittable          // inherit interface
    {
        
            public void Quit()    
            {
                Console.WriteLine("An employee has quit");       // implement void method from interface

            }
        
    }
}

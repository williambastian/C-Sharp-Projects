using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Methods_Named_Parameters
{
    class VoidMath
    {
        //create a void method that takes two integers as parameters.
        //Do a math operation on the first integer, and display the second integer to the screen
        public void NamedParams(int paramOne, int paramTwo)              //void method does not strictly return an integer, requires no return statement
        {                                                                // named parameters can be given out of order, as seen in Program.cs
            int resultOne = paramOne * 2;          // sample math operation on first parameter
            Console.WriteLine("Your first integer times two equals: " + resultOne);         //display result of math operation
            Console.WriteLine("Your second integer: " + paramTwo);                          // display unaltered second parameter
        }
    }
}

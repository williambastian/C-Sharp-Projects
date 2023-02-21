using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Demo
{
    class Program
    {
        // Step 1: Create struct called Number, give it property "Amount" of type decimal - see Number.cs
        // Step 2: Create object of data type Number and assign a value to Amount
        // Print object's amount to console

        static void Main(string[] args)
        {
            Number number = new Number();    // create object of Number type
            number.Amount = 3.50m;           // assign amount
            Console.WriteLine(number.Amount);                // print amount for specific object to console
            Console.ReadLine();
        }
    }
}

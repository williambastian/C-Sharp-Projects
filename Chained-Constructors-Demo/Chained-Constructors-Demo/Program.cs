using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chained_Constructors_Demo
{
    class Program
    {
        // Step 1 - create a const variable
        // Step 2 - create variable using keyword "var"
        // Step 3 - chain two constructors together - see Animals.cs

        static void Main(string[] args)
        {
            const string creatorName = "William";   // const string creatorName can only be assigned once, and not reassigned
            var welcomeName = creatorName;          // var welcomeName does not require the "string" keyword in the variable declaration
            Console.WriteLine("Hello {0}", welcomeName); // string formatting can be used on welcomeName, even though it was not explicitly declared as a string type

            //creatorName = "Andrew";        //<<const values cannot be reassigned. Uncomment this line to see error displayed

            var animal1 = new Animals();    // when no parameters are entered, the default values will be assigned to each property
            var animal2 = new Animals("Cat", "Male", "Orange");   // when parameters are entered, they will be assigned instead of the default values
            Console.WriteLine("{0}, {1}, {2}", animal1.Species, animal1.Sex, animal1.Color);
            Console.WriteLine("{0}, {1}, {2}", animal2.Color, animal2.Sex, animal2.Species);
            Console.ReadLine();
        }
    }
}

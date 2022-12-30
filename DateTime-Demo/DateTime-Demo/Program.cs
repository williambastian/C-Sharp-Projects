using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Demo
{
    class Program
    {   // Step 1: Print current date and time to console
        // Step 2: Take a number from the user. That number of hours will be added to the current date and time.
        // Step 3: Print the date and time after adding the user-provided number of hours to current date and time.

        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;    // assign current date and time to a variable called currentTime
            Console.WriteLine("Current Date and Time: " + currentTime);  // print currentTime to console
            Console.WriteLine("Please enter a number.");     // prompt user to enter a number
            double number = Convert.ToDouble(Console.ReadLine());
            DateTime futureTime = currentTime.AddHours(number);  // use the .AddHours() method to add the user's number to the current date and time as a number of hours
            Console.WriteLine("You entered {0}. In {0} hours, the date and time will be {1}.", number, futureTime);    // print the future time to the console.
            

            Console.ReadLine();
        }
        
    }
}

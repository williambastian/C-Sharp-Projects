using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_Demo
{
    class Program
    {
        // Step 1: Create an enum for days of the week. See Days.cs
        // Step 2: Prompt user to enter current day of the week
        // Step 3: Assign user input value to variable of the enum data type created for days of the week
        // Step 4: Wrap the user-input into a try/catch block, and print "please enter a valid day of the week" if an error occurs.

        static void Main(string[] args)
        {
            
            try
            {
                weekDays currentDay;    // declare variable of enum type, which will hold user-input value
                Console.WriteLine("Please type the current day of the week:");   // prompt user input for current day of the wek  
                string userDayRaw = Console.ReadLine();                               // lines 23 - 27: cleaning user input to allow for leading / trailing spaces, and any-case input
                string userDayTrim = userDayRaw.Trim();
                string userDayFirstChar = userDayTrim.Substring(0, 1).ToUpper();
                string userDayOtherChars = userDayTrim.Substring(1).ToLower();
                string userDay = userDayFirstChar + userDayOtherChars;
                
                if (Enum.TryParse(userDay, out currentDay))   // TryParse user-input (userDay) as a valid value in the enum (weekDays
                {                                             // if valid, userDay is assigned to currentDay, the variable of enum type
                    Console.WriteLine("Today is " + currentDay);    // if valid, console prints currentDay
                }
                
                else
                {
                    throw new ArgumentException();           // if not valid, ArgumentExcepction is thrown
                }


            }
            catch(ArgumentException)
            {
                Console.WriteLine("Please enter a valid day of the week.");    // catch block prints ArgumentException statement
            }
            Console.ReadLine();
        }
    }
}

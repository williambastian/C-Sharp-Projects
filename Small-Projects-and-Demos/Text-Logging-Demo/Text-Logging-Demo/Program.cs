using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // use the System.IO namespace to enable StreamWriter and other File IO functionality

namespace Text_Logging_Demo
{
    class Program
    {
        // Step 1: Ask user for a number
        // Step 2: Log that number to a text file.
        // Step 3: Print the text file back to the user.

        static void Main(string[] args)
        {
            // Ask for number input
            Console.WriteLine("Please enter a number");
            double number = Convert.ToDouble(Console.ReadLine());

            // Log input to text file
            // create StreamWriter object
            // specify the file name, and whether to append to the file (the 'true' parameter)
            // use .WriteLine() to write to the designated file (here the value of the 'number' variable)

            using (StreamWriter logText = new StreamWriter("log.txt", true))      //log.txt will be created in same directory as the program's executable file if it does not already exist
            {
                logText.WriteLine(number);
            }
            // print text file back to user
            // create a StreamReader object, designate which file to read
            // create a string variable to hold the information to be read to console
            // create a while loop that assigns each line of the designated file to the string variable,
            //  and prints that line until the line's value is null
            using (StreamReader readText = new StreamReader("log.txt"))
            {
                string logLine;
                while ((logLine = readText.ReadLine()) != null)
                {
                    Console.WriteLine(logLine);
                }
            }
            Console.ReadLine();
        }
    }
}

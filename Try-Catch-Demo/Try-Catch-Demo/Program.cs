using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_Demo
{
    class Program
    {
        static void Main()
        {
            // Step 1 & Step 2: Create a list of integers. Ask user for number to divide each number by.
            //  Write a loop that takes each integer in the list, divides it by the user given number,
            //  and shows the result to the screen.

            // Step 3:   Enter [ 0 ] as the number to divide by.
            // This results in error [ System.DivideByZeroException: 'Attempted to divide by zero.' ]
            // 
            // Step 4: Enter a non-numeric string as the number to divide by.
            // This results in error [  System.FormatException: 'Input string was not in a correct format.' ]

            // Step 5: put loop in a try/catch block.
            // Outside the try/catch block, print a message the program is continuing after the block.

            // The initial part of the program goes in the try block
            try
            {
                List<int> sampleIntegerList = new List<int>() { 2, 4, 6, 8, 10 };
                Console.WriteLine("Here is a list of integers:");
                for (int i = 0; i < sampleIntegerList.Count; i++)
                {
                    Console.WriteLine(sampleIntegerList[i]);
                }
                Console.WriteLine("Type an integer. Each number in the list will be divided by your integer.");
                string userDivisorString = Console.ReadLine();
                int userDivisorInt = Convert.ToInt32(userDivisorString);

                for (int i = 0; i < sampleIntegerList.Count; i++)
                {
                    int quotient = (sampleIntegerList[i] / userDivisorInt);
                    Console.WriteLine(quotient);
                }


                Console.Read();
            }

            catch (DivideByZeroException divZero)           // if we attempt to divide by zero, this message should print
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            catch (FormatException badFormat)     // if we attempt the wrong data format for input, this should print
            {
                Console.WriteLine("Please enter a valid integer.");
            }

            catch (Exception otherError)
            {
                Console.WriteLine(otherError.Message);
            }

            Console.WriteLine("Exiting Try/Catch sequence. Continue Program.");   //This will print after the try/catch finishes
            Console.Read();

        }
    }
}

using System;


namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Math and Comparison Operators Demo");

            // Demo 01: Multiply a user-input number by 50

            // declare variable to hold user input as a double
            double entry01double;

            // prompt user input
            Console.WriteLine("Enter a number to multiply by 50:");

            // store initial input as string, to be validated in next steps
            string entry01string = Console.ReadLine();

            // validates string as possible to parse to double
            while (!Double.TryParse(entry01string, out entry01double))   // the while loop will run until a valid, parseable value is entered, allowing user to retry
            {
                Console.WriteLine("Please enter a valid number, with no non-number characters.");    // error prompt
                entry01string = Console.ReadLine();      //returns user to input stage
            }
            entry01double = Convert.ToDouble(entry01string);  // once validated, convert entry to double
            double answer01double = entry01double * 50.0;     // create new variable to store product of user entry and constant (50)
            string answer01string = Convert.ToString(answer01double);  //convert product back to string for output to console
            Console.WriteLine("Your number multiplied by 50 is: " + answer01double);   //write result for viewing in console
            


            // Demo 2: Take input from user and add 25
            // Operations are the same as Demo 1, but with unique variable names and different arithmetic
            // Arithmetic is (x + 25) where x is user input

            double entry02double;
            Console.WriteLine("Enter a number to add to 25:");
            string entry02string = Console.ReadLine();

            while (!Double.TryParse(entry02string, out entry02double))
            {
                Console.WriteLine("Please enter a valid number, with no non-number characters.");
                entry02string = Console.ReadLine();
            }

            entry02double = Convert.ToDouble(entry02string);
            double answer02double = entry02double + 25;
            string answer02string = Convert.ToString(answer02double);
            Console.WriteLine("Your number added to 25 is: " + answer02double);


            // Demo 3: Take input from user and divide by 12.5
            // Operations are the same as Demo 1, but with unique variable names and different arithmetic
            // Arithmetic is (x / 12.5) where x is user input

            double entry03double;
            Console.WriteLine("Enter a number to divide by 12.5:");
            string entry03string = Console.ReadLine();

            while (!Double.TryParse(entry03string, out entry03double))
            {
                Console.WriteLine("Please enter a valid number, with no non-number characters.");
                entry03string = Console.ReadLine();
            }

            entry03double = Convert.ToDouble(entry03string);
            double answer03double = entry03double / 12.5;
            string answer03string = Convert.ToString(answer03double);
            Console.WriteLine("Your number divided by 12.5 is: " + answer03double);


            // Demo 04: Check if user input number is greater than 50 (x > 50). Output should print "true" or "false" to console.
            double entry04double;
            Console.WriteLine("Enter a number to check if it is greater than 50:");
            string entry04string = Console.ReadLine();

            while (!Double.TryParse(entry04string, out entry04double))
            {
                Console.WriteLine("Please enter a valid number, with no non-number characters.");
                entry04string = Console.ReadLine();
            }

            entry04double = Convert.ToDouble(entry04string);
            bool answer04bool = entry04double > 50.0;        // the variable storing the result of the comparison is a bool in this scenario
            string answer04string = Convert.ToString(answer04bool);     //The remaining steps are similar: convert the boolean output (true or false) to a string, and write to console
            Console.WriteLine("Your number is greater than 50: " + answer04string);

            // Demo 5: Take input from user, divide by 7, print remainder to console
            // Demonstrates use of modulo operator (x % 7)

            double entry05double;
            Console.WriteLine("Enter a number to be divided by 7. \nThe output will be the remainder of your number divided by 7:");
            string entry05string = Console.ReadLine();

            while (!Double.TryParse(entry05string, out entry05double))
            {
                Console.WriteLine("Please enter a valid number, with no non-number characters.");
                entry05string = Console.ReadLine();
            }

            entry05double = Convert.ToDouble(entry05string);
            double answer05double = entry05double % 7;
            string answer05string = Convert.ToString(answer05double);
            Console.WriteLine("After dividing your number by 7, the remainder is: " + answer05string);

            Console.Read();



        }
    }
}

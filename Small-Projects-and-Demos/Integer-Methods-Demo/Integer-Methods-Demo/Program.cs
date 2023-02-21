using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Methods_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            IntMath intMath = new IntMath();   //to use the methods in the IntMath class, we first instantiate the class

            try //we are taking user input, so structure program in a try-catch block, expecting errors
            {
                Console.WriteLine("Enter an integer to be squared:");       //give instructions to the user, request the needed paramater for each class
                string num1string = Console.ReadLine();                     //user input stored as string
                int num1 = Convert.ToInt32(num1string);                     //convert to Integer; this is where errors are likely
                int result1 = intMath.IntSquared(num1);                     //call intMath.IntSquared() method using converted user input as parameter
                Console.WriteLine(num1 + " squared is " + result1);         // write output of IntSquared() to console

                Console.WriteLine("Enter an integer to be doubled:");       //methodology for IntDoubled() and IntTimesTen() are the same as above
                string num2string = Console.ReadLine();
                int num2 = Convert.ToInt32(num2string);
                int result2 = intMath.IntDoubled(num2);
                Console.WriteLine(num2 + " doubled is " + result2);

                Console.WriteLine("Enter an integer to be multiplied by ten:");
                string num3string = Console.ReadLine();
                int num3 = Convert.ToInt32(num3string);
                int result3 = intMath.IntTimesTen(num3);
                Console.WriteLine(num3 + " times 10 is " + result3);
            }
            catch (FormatException badFormat)                          //the catch block anticipates invalid format from the user
            {
               Console.WriteLine("Please enter a valid integer.");
            }
            catch (Exception generalError)                             //catch block for unforseen errors
            {
                Console.WriteLine("Unknown error occurred. Please try again.");
            }

            Console.Read();
        }
    }
}

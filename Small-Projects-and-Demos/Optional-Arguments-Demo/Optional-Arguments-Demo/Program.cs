using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Optional_Arguments_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
                MoreMath moreMath = new MoreMath();   //instantiate MoreMath class
                Console.WriteLine("Enter an integer");

                int resultInt = 0;    //initialize result variable

                int userInt;    //initialize user response variable
                if (Int32.TryParse(Console.ReadLine(), out userInt))     //use TryParse to verify valid input
                {
                    Console.WriteLine("Pick another integer. Invalid values will be ignored. (optional)");
                    int userInt2;   //initialize variable for second user response, if given
                    if (Int32.TryParse(Console.ReadLine(), out userInt2))   //if the response parses to an integer, run both parameters
                    {
                        resultInt = moreMath.argsDemo(userInt, userInt2);
                    }
                    else
                    {
                        resultInt = moreMath.argsDemo(userInt);   //if the response does not parse to an integer, run with only the required parameter
                    }
                    Console.WriteLine(resultInt);
                }
                else
                {
                    Console.WriteLine("No valid input");    //if the required input does not parse to an integer, return error message
                }
            
            Console.ReadLine();
        }
    }
}

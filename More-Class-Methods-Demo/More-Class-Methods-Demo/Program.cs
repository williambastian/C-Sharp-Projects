using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace More_Class_Methods_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step 1: Create a class. In that class create a void method that outputs an integer. Have method divide (data passed in) by two.
            // See MoreMethods.cs

            // Step 2: In Main() method, instantiate the class.
            try
            {
                MoreMethods moreMethods = new MoreMethods();
                Console.WriteLine("Enter an integer to divide by two:");

                // Step 3: Have user enter a number, call method on that number, display output to screen.
                int userInput = Convert.ToInt32(Console.ReadLine());
                moreMethods.DivByTwo(userInput);

                // Step 4: Create method with output parameters. See MoreMethods.OutParams()
                int x, y;    // declare variables with no assigned values
                moreMethods.OutParams(out x, out y);
                Console.WriteLine("The value of x + x is: {0}", x);      //display values of x and y, which are assigned within the method
                Console.WriteLine("The value of y + y is: {0}", y);

                // Step 5: Overload a method
                double b, c;
                moreMethods.OutParams(out b, out c);                //OutParams() is shown here accepting different inputs. 
                Console.WriteLine("The value of b + b is: {0}", b); // Based on the type of inputs received, the behavior can be changed while using the same method name (aka, overloading)
                Console.WriteLine("The value of c + c is: {0}", c);

                //Step 6: Declare a class to be static  - see StaticClass.cs
                StaticClass.divideByFour(4.4);            //no need to instantiate class, or to call an instantiated class variable



            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid integer");
            }
            catch(Exception)
            {
                Console.WriteLine("An error occurred");
            }
            Console.ReadLine();
            

        }

         
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate class containing overloaded method someMath()

            MathMethods mathMethods = new MathMethods();

            try   // each method is dependent on valid input. try-catch anticipates invalid input
            {
                // the first version of someMath adds a given integer to 5
                Console.WriteLine("Please enter an integer to be added to 5");
                int userInt = Convert.ToInt32(Console.ReadLine());    //user input is converted to int before passing into someMath()
                int result1 = mathMethods.someMath(userInt);    // someMath receives an integer, and knows to perform +5
                Console.WriteLine(result1);

                Console.WriteLine("Please enter a decimal to be multiplied by 12");
                decimal userDec = Convert.ToDecimal(Console.ReadLine());   //user input converted to decimal before passing into someMath()
                int result2 = mathMethods.someMath(userDec);               //when someMath() receives decimal input, it multiplies input by 12
                Console.WriteLine(result2);

                Console.WriteLine("Please enter an integer to multiplied by 3");
                string userString = Console.ReadLine();                       //if user input is not converted, it remains a string
                int result3 = mathMethods.someMath(userString);               // passing string data into someMath() results in input multiplied by 3
                Console.WriteLine(result3);


            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Format");
            }
            catch(Exception)
            {
                Console.WriteLine("Unknown Error");
            }
            Console.Read();
        }
    }
}

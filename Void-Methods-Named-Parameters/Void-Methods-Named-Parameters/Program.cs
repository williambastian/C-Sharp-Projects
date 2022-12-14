using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Void_Methods_Named_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                VoidMath voidMath = new VoidMath();   //instantiate class containing void method
                Console.WriteLine("Enter two integers.\nThe first integer will be doubled, and the second integer will be printed without changes.\nEnter the first integer now:");
                int userNum1 = Convert.ToInt32(Console.ReadLine());     //convert user input to first integer
                Console.WriteLine("Enter the second integer now:");
                int userNum2 = Convert.ToInt32(Console.ReadLine());     //convert user input to second integer
                voidMath.NamedParams(paramTwo: userNum2, paramOne: userNum1);    //call method using specific parameter names. Note these are given out of order, but they function normally

            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a valid integer");
            }
            catch(Exception)
            {
                Console.WriteLine("Unknown Error");
            }
            Console.ReadLine();
        }
    }
}

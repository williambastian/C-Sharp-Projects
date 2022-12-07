using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Demo
{
    class Program
    {         
        static void Main()
        {
            //Demo 1: create array of strings, ask for user to provide an input, use that input as an index, return corresponding array value.

            string[] iceCreamFlavors = { "Vanilla", "Chocolate", "Strawberry" };   //declare string array
            Console.WriteLine("Type an index value of 0, 1, or 2 to see the corresponding ice cream flavor.");  //user instructions

            string flavorInput = Console.ReadLine();  //accept user input as string, for validation
            int flavorIndex;           //declare integer variable, which will ultimately be used as an index for the array.

            // the while loop structure allows the user to keep trying inputs until they submit a valid index
            // user input must be an integer with a value of 0, 1, or 2.

            // the order of the parameters is important:
            // the first check must be for a value that parses to an integer.
            // if the first check is not a TryParse, then the program will break in the event of an invalid data type.

            // the second check makes sure user input is not greater than the maximum index value for the array.
            // the third check makes sure user input is not lesser than 0, the minimum value for the array.

            // invalid answers can be given in any order, indefinitely, without breaking the program
            // entering (f, -1, f, 100, 2.3, ff, -100.444) in that order, etc, should not break the while loop or throw an exception.

            while (((!Int32.TryParse(flavorInput, out flavorIndex))) || ((Convert.ToInt32(flavorInput)) > ((iceCreamFlavors.Length) - 1)) || ((Convert.ToInt32(flavorInput)) < 0))
            {
                Console.WriteLine("Please enter an integer value of 0, 1, or 2.");
                flavorInput = Console.ReadLine();
            }
            // once the user input is validated, it is converted to an integer            
            flavorIndex = Convert.ToInt32(flavorInput);
            // the validated integer value is used to write the corresponding array value to the console.
            Console.WriteLine(iceCreamFlavors[flavorIndex]);


            // Demo 2: integer array. 
            // the input parameters, structure, and validation checks are the same here, but the array values are integers instead of strings.

            int[] iceCreamID = { 100, 200, 300 };

            Console.WriteLine("Type an index value of 0, 1, or 2 to see the corresponding integer.");

            string intInput = Console.ReadLine();
            int intIndex;

            while (((!Int32.TryParse(intInput, out intIndex))) || ((Convert.ToInt32(intInput)) > ((iceCreamID.Length) - 1)) || ((Convert.ToInt32(intInput)) < 0))
            {
                Console.WriteLine("Please enter a valid number, with no decimals or non number characters.");
                intInput = Console.ReadLine();  //returns user to input if their initial response is invalid
            }
                     
            intIndex = Convert.ToInt32(intInput);

            Console.WriteLine(iceCreamID[intIndex]);

            // Demo 3: Create list of strings, ask user to provide index, return list value for that index
            // similar to array demo structure, but with list format instead

            //declare list with string type data, and populate it with strings
            List<string> sizeList = new List<string>();
            sizeList.Add("Kids Cup");
            sizeList.Add("Regular Cup");
            sizeList.Add("Waffle Cone");

            Console.WriteLine("Type an index value of 0, 1, or 2 to see the corresponding ice cream size.");
            string sizeInput = Console.ReadLine();
            int sizeIndex;

            // The while loop for validation uses .Count to calculate the size of the list, instead of .Length
            while (((!Int32.TryParse(sizeInput, out sizeIndex))) || ((Convert.ToInt32(sizeInput)) > ((sizeList.Count) - 1)) || ((Convert.ToInt32(sizeInput)) < 0))
            {
                Console.WriteLine("Please enter a valid number, with no decimals or non number characters.");
                sizeInput = Console.ReadLine();  //returns user to input if their initial response is invalid
            }

            sizeIndex = Convert.ToInt32(sizeInput);

            Console.WriteLine(sizeList[sizeIndex]);

            Console.Read();                 

        }
    }
}
                                                
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace String_Demo
{
    class Program
    {
        static void Main()
        {
            // Demo 1 - Concatenate 3 strings
            string string1 = "A";
            string string2 = "B";
            string string3 = "C";

            string string4 = string1 + string2 + string3;
            Console.WriteLine(string4);

            // Demo 2 - convert string to uppercase
            string string5 = "xyz";
            Console.WriteLine("Before using ToUpper() the string is " + string5 + ". Afterwards, it is: ");
            string upper = string5.ToUpper();
            Console.WriteLine(upper);

            // create paragraph with stringbuilder
            StringBuilder stringGraph = new StringBuilder();       //This creates a StringBuilder object, which allows us to append text rather than overwrite it.

            stringGraph.Append("Sentence 1.");
            stringGraph.Append("\nSentence 2.");
            stringGraph.Append("\nSentence 3. This is a StringBuilder Paragraph.");
            Console.WriteLine(stringGraph);           //stringGraph is now equal to all of these string segments. The original was not overwritten as the additional characters were appended.

            Console.Read();
        }
    }
}

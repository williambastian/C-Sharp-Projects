using System;


namespace Daily_Report_Console_App
{
    class Program
    {
        static void Main()
        {
            // First, display title and subtitle of Daily Report
            Console.WriteLine("The Tech Academy.\nStudent Daily Report");

            // Question 01
            // user response to question 1 is stored as a string variable called studentName
            Console.WriteLine("Question 1: What is your name?");       
            string studentName = Console.ReadLine();

            // Question 02
            // user response to question 2 is stored as a string variable called studentCourse
            Console.WriteLine("Question 2: What course are you on?");  
            string studentCourse = Console.ReadLine();                 

            // Question 03
            // page number must be an integer

            int studentPage;    //declare integer variable for use in TryParse, to prevent unhandled exceptions from non-integer inputs
            Console.WriteLine("Question 3: What page number?");
            
            // initial user input stored as string
            string studentPageString = Console.ReadLine();

            // while loop runs while Int32.TryParse returns a false output, aka the user input cannot be converted to integer
            while (!Int32.TryParse(studentPageString, out studentPage))
            {
                Console.WriteLine("Please enter a valid number, with no decimals or non number characters.");
                studentPageString = Console.ReadLine();  //returns user to input if their initial response is invalid
            }
            //assign initial int variable the value based on conversion of validated user input
            studentPage = Convert.ToInt32(studentPageString);
            //Console.WriteLine("You are on page " + Convert.ToString(studentPage) + ".");   //debug line: make sure variable assignment and conversion were successful

            // Question 04
            bool studentHelpBool;
            Console.WriteLine("Question 4: Do you need help with anything? Please answer \"true\" or \"false.\"");
            //tryparse for boolean after cleaning user input//
            string studentHelp = Console.ReadLine();
            while (!(Boolean.TryParse(studentHelp, out studentHelpBool)))
            {
                Console.WriteLine("If you need help, type the following in lowercase: true\nIf you do not need help, type the following in lowercase: false\nDo not include spaces.");
                studentHelp = Console.ReadLine();
            }


            // Question 05
            Console.WriteLine("Question 5: Were there any positive experiences you'd like to share? Please give specifics.");
            string studentPositives = Console.ReadLine();

            // Question 06
            Console.WriteLine("Question 6: Is ther any other feedback you'd like to provide? Please give specifics.");
            string studentOtherFeedback = Console.ReadLine();

            // Question 07
            Console.WriteLine("How many hourse did you study today?");
            string studentDayHours = Console.ReadLine(); // string was chosed for this data type assuming manual review and no arithmetic operations. If student hours responses require arithmetic operations, a different data type may be necessary.

            // End of form confirmation
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly.\nHave a great day!");



            


            Console.Read();

            
        }

        
    }
}

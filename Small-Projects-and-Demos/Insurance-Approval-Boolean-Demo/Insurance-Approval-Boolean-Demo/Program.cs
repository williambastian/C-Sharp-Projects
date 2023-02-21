using System;


namespace Insurance_Approval_Boolean_Demo
{
    class Program
    {
        static void Main()
        {
            // Question 1: What is the user's age
            Console.WriteLine("What is your age? Please enter a number:");
            string userAge = Console.ReadLine();    //user input stored as string, for validation
            uint userAgeInt;  //declare variable to hold validated and parsed user input
            
            // validation of user input. make sure their answer can be parsed as the necessary data type
            while (!UInt32.TryParse(userAge, out userAgeInt))
            {
                Console.WriteLine("Please enter a valid age in whole numbers, with no non-number characters. Round down to the nearest year.");
                userAge = Console.ReadLine();
            }
            // set the variable to be used in later comparisons to the necessary data type
            userAgeInt = Convert.ToUInt32(userAge);

            // Question 2: Has the user had any DUI's
            // these steps are similar to question 1. Instead of unsigned integers, we want boolean data.

            Console.WriteLine("Have you ever had a DUI?\nIf yes, type: true\n If no, type: false");
            string userDUIstring = Console.ReadLine().ToLower();     //The ToLower method helps reduce user errors where they enter the correct word with incorrect capitalization
            bool userDUIbool;    //declare variable which will be used for comparison later
            
            // validation steps
            while (!Boolean.TryParse(userDUIstring, out userDUIbool))
            {
                Console.WriteLine("Please enter a valid response. \nIf yes, type: true\n If no, type: false");
                userDUIstring = Console.ReadLine().ToLower();
            }

            // set value of variable to be used in comparison
            userDUIbool = Convert.ToBoolean(userDUIstring);


            // Question 3: How many speeding tickets does the user have on their record
            // same steps as question 1, but with different variables, because the comparison will be against different criteria
            Console.WriteLine("How many speeding tickets do you have? Please enter a whole number.");
            string userTicketsString = Console.ReadLine();
            uint userTicketsInt;
            while (!UInt32.TryParse(userTicketsString, out userTicketsInt))
            {
                Console.WriteLine("Please enter a valid response, using only numeric characters.");
                userTicketsString = Console.ReadLine();
            }
            userTicketsInt = Convert.ToUInt32(userTicketsString);


            // Comparison steps
            // Check responses for each question against qualification criteria. 
            // If applicant clears ALL criteria, they are qualified for insurance.

            //Age Criterion
            bool ageQualify = userAgeInt >= 15;   //user input must be greater or equal to 15 years of age (no partial age in months or days is acceptable)

            //DUI Criterion
            bool duiQualify = !userDUIbool;    //user must have no DUI's. The "!" negates the value of userDUIbool. Because userDUIbool must be false, this returns true.
            

            //Speeding Ticket Criterion
            bool ticketQualify = userTicketsInt <= 3;     //user tickets cannot exceed 3. A user with 3 tickets will qualify.

            bool insuranceQualify = (ageQualify && duiQualify && ticketQualify);     //if any of the three criteria fail, the variable insuranceQualify will evaluate as false, meaning the applicant does not qualify.

            Console.WriteLine("Based on your responses, this applicant's qualification for insurance is: ");
            Console.WriteLine(insuranceQualify);
            Console.Read();
        }
    }
}

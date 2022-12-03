using System;


namespace Shipping_Quote_Demo
{
    class Program
    {
        static void Main()
        {
            // Print Title
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            
            // Check package weight
            Console.WriteLine("Please enter the package weight in pounds. Enter numeric characters only:");
            double packageWeight = Convert.ToDouble(Console.ReadLine());     //convert user input to double, for math and comparison
            if (packageWeight > 50)     //check to see if package is too heavy
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();       //Pauses program after error message
                Environment.Exit(0);  //closes program when package is too large
            }
            
            // Check package width
            Console.WriteLine("Please enter package width in inches. Enter numeric characters only:");
            double packageWidth = Convert.ToDouble(Console.ReadLine());
            if (packageWidth > 50)                  // check if too wide
            {
                Console.WriteLine("Packages wider than 50 inches cannot be shipped via Package Express.");
                Console.Read();       //Pauses program after error message
                Environment.Exit(0);  //closes program when package is too large
            }

            // Check package height
            Console.WriteLine("Please enter package height in inches. Enter numeric characters only:");
            double packageHeight = Convert.ToDouble(Console.ReadLine());
            if (packageHeight > 50)           // check if too tall
            {
                Console.WriteLine("Packages taller than 50 inches cannot be shipped via Package Express.");
                Console.Read();       //Pauses program after error message
                Environment.Exit(0);  //closes program when package is too large
            }

            // Check package length
            Console.WriteLine("Please enter package length in inches. Enter numeric characters only:");
            double packageLength = Convert.ToDouble(Console.ReadLine());
            if (packageLength > 50)                 //check if too long
            {
                Console.WriteLine("Packages longer than 50 inches cannot be shipped via Package Express.");
                Console.Read();       //Pauses program after error message
                Environment.Exit(0);  //closes program when package is too large
            }

            // Generate quote
            double quoteAmount = ((packageWeight * packageWidth * packageHeight * packageLength) / 100); //sample rate calculation. Note, this quote will not be realistically competitive (all dimensions and weights at 49 result in approximately $57k in shipping charges, wow)
            double roundedAmount = Math.Round(quoteAmount, 2);        //trim quote amount to two decimal places, for dollar amount
            string quoteString = Convert.ToString(roundedAmount);   // convert to string for easy formatting
            Console.WriteLine("Your estimated total for shipping this package is: $" + quoteString + ". Thank you!");
            Console.Read();


        }
    }
}

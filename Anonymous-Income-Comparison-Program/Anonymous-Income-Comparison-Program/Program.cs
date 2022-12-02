using System;


namespace Anonymous_Income_Comparison_Program
{
    class Program
    {
        static void Main()
        {
            // Print Title
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("\nPerson 1:\nWhat is your hourly rate?");
            decimal hourlyRate01decimal;
            string hourlyRate01string = Console.ReadLine();

            while (!Decimal.TryParse(hourlyRate01string, out hourlyRate01decimal))
            {
                Console.WriteLine("Please enter a valid hourly rate, with no non-number characters.");
                hourlyRate01string = Console.ReadLine();
            }

            Console.WriteLine("How many hours do you work each week?");
            decimal weeklyHours01decimal;           //decimal data type is probably overkill for programs with a large number of calculations, but for ease of interoperability in a small console app we can use it for weekly hours.
            string weeklyHours01string = Console.ReadLine();

            while (!Decimal.TryParse(weeklyHours01string, out weeklyHours01decimal))
            {
                Console.WriteLine("Please enter a valid hourly rate, with no non-number characters.");
                weeklyHours01string = Console.ReadLine();
            }

            hourlyRate01decimal = Convert.ToDecimal(hourlyRate01string);
            weeklyHours01decimal = Convert.ToDecimal(weeklyHours01decimal);
            decimal weeksPerYear = 52m;

            decimal annualSalary01decimal = (hourlyRate01decimal * weeklyHours01decimal * weeksPerYear);
            string annualSalary01string = Convert.ToString(annualSalary01decimal);

            // Person 2 Input

            Console.WriteLine("\nPerson 2:\nWhat is your hourly rate?");
            decimal hourlyRate02decimal;
            string hourlyRate02string = Console.ReadLine();

            while (!Decimal.TryParse(hourlyRate02string, out hourlyRate02decimal))
            {
                Console.WriteLine("Please enter a valid hourly rate, with no non-number characters.");
                hourlyRate02string = Console.ReadLine();
            }

            Console.WriteLine("How many hours do you work each week?");
            decimal weeklyHours02decimal;           //decimal data type is probably overkill for programs with a large number of calculations, but for ease of interoperability in a small console app we can use it for weekly hours.
            string weeklyHours02string = Console.ReadLine();

            while (!Decimal.TryParse(weeklyHours02string, out weeklyHours02decimal))
            {
                Console.WriteLine("Please enter a valid hourly rate, with no non-number characters.");
                weeklyHours02string = Console.ReadLine();
            }

            hourlyRate02decimal = Convert.ToDecimal(hourlyRate02string);
            weeklyHours02decimal = Convert.ToDecimal(weeklyHours02decimal);
            

            decimal annualSalary02decimal = (hourlyRate02decimal * weeklyHours02decimal * weeksPerYear);
            string annualSalary02string = Convert.ToString(annualSalary02decimal);

            // Write to console both annual salaries
            Console.WriteLine("Annual Salary of Person 1:\n$" + annualSalary01string);
            Console.WriteLine("Annual Salary of Person 2:\n$" + annualSalary02string);

            // Salary Comparison
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool greaterSalary = annualSalary01decimal > annualSalary02decimal;
            
            Console.WriteLine(greaterSalary);
            







            Console.Read();
        }
    }
}

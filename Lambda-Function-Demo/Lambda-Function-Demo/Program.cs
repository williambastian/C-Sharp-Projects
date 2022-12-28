using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Function_Demo
{
    class Program
    {
        // Step 1: Create Employee class with properties FirstName, LastName, and ID - See Employee.cs
        // Step 2: In the Main() method create a list of at least 10 employees, two of which have identical FirstName values ("Joe").
        // Step 3: Use a foreach loop to create a new list of only employees with FirstName "Joe"
        // Step 4: Create a list of only Employees w/ FirstName "Joe" using a lambda function
        // Step 5: Use lambda function to create list of employees with ID < 5
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();  // new list of class objects
            List<Employee> joes = new List<Employee>();       // list created to hold only employees named Joe
            employees.Add(new Employee { FirstName = "Joe", LastName = "A", ID = 1 });     // Add 10 employee objects, the long way
            employees.Add(new Employee { FirstName = "Joe", LastName = "B", ID = 2 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "C", ID = 3 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "D", ID = 4 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "E", ID = 5 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "F", ID = 6 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "G", ID = 7 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "H", ID = 8 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "I", ID = 9 });
            employees.Add(new Employee { FirstName = "Bob", LastName = "J", ID = 10 });
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")      //reference specific FirstName property of each object in the foreach loop
                {
                    joes.Add(employee);               // add each Joe to the joes list
                }
                
            }
            foreach(Employee employee in joes)       // display result of joes only list, created the long way
            {
                Console.WriteLine(employee.FirstName);
            }

            //lambda function to achieve results of step 2 and step 3
            //create new list lambdaJoes, use the .Where() method to filter list based on FirstName
            //use .ToList() to add valid objects to the lambdaJoes list

            List<Employee> lambdaJoes = employees.Where(x => x.FirstName == "Joe").ToList();   
            foreach(Employee employee in lambdaJoes)
            {
                Console.WriteLine(employee.FirstName + " Lambda");    //write the FirstName values of all objects in lambdaJoes, plus "Lambda" to differentiate from initial list above
            }

            //  same functionality and implementation as the "Joe" function above, but comparison statement uses [ ID < 5 ] instead of [ FirstName == "Joe"]
            List<Employee> idsUnderFive = employees.Where(y => y.ID < 5).ToList();
            foreach(Employee employee in idsUnderFive)
            {
                Console.WriteLine(employee.FirstName + "; ID = " + employee.ID);   //write names and ID's of employees that were added to new list
            }
            

            Console.ReadLine();

           
        }
    }
}

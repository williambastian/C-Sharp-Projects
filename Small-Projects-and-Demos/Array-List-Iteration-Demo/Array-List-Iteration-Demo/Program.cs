using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_Iteration_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1 of 6:
            // 1a: Create one dimensional array of strings
            // 1b: take user input as string
            // 1c: iterate through each array item, and append user string to each one
            // 1d: create second loop to print off each string in the array one at a time

            // instantiate array of strings
            string[] coffeeOrders = { "Drip", "Cappuccino", "Cold Brew", "Latte", "Espresso", "Americano" };

            // prompt user for text input
            Console.WriteLine("Demo 1: \nWhat size coffee would you like? Type your answer.");

            // store user input in string variable
            string sizeInput = Console.ReadLine();

            // loop through initial array values and update each value to include user input
            for (int i = 0; i < coffeeOrders.Length; i++)
            {
                coffeeOrders[i] = coffeeOrders[i] + ", " + sizeInput;
            }

            // loop through updated array and print each new value
            for (int i = 0; i < coffeeOrders.Length; i++)
            {
                Console.WriteLine(coffeeOrders[i]);
            }

            // Step 2 of 6:
            // Add an infinite loop
            // Update infinite loop to be finite and useful

            // Example infinite loop
            // un-comment the for loop block to run this demo

            //for (int i = 0; i > (-1); i++) //i is always greater than (-1), and it only increments to greater values with each loop,  so the loop will run forever. Not useful behavior
            //{
            //    Console.WriteLine(i + " oops, no exit condition");    //exceeding the size of the array would normally break the program, and therefore the loop, but this is written to be infinite.
            //}

            // end infinite loop example

            // A functional loop:

            //using the logic from Step 1 above, we set our parameters to be self limiting.
            //i increases in value with each loop, and only runs while it is below a certain value.
            //Eventually it will hit an upper bound and the loops will stop.

            //Outputs of this loop are evident by the final sentence, which requests payment for each coffee.
            Console.WriteLine("\nDemo 2: \n");
            for (int i = 0; i < coffeeOrders.Length; i++)
            {
                Console.WriteLine(coffeeOrders[i] + ".  That will be $5 please.");
            }


            // Step 3
            // Create a loop where the iteration is based on the comparison operator [ < ]
            // Create another loop where the comparison is [ <= ]

            // For this loop, we will convert the index i into a suggested tip value.
            Console.WriteLine("\nDemo 3a: \n");
            for (int i = 0; i < coffeeOrders.Length; i++) //we use [ < ] as our comparison operator 
            {
                string tipString = Convert.ToString(i + 1); // it is never polite to tip $0; add 1 to each index value
                Console.WriteLine(coffeeOrders[i] + ". Suggested tip: $" + tipString);
            }

            // For the next loop, we can use [ i <= (coffeeOrders.Length -1) ] to demonstrate the flexibility of defining parameters
            Console.WriteLine("\nDemo 3b: \n");
            for (int i = 0; i <= (coffeeOrders.Length - 1); i++) //we use [ <= ] as our comparison operator 
            {
                Console.WriteLine(coffeeOrders[i] + ", as a parameter demo");
            }
            // to get all items in the array to write, without requesting an index value that is out of range,
            // we have to modify the Length of the array by -1 when using <=. This is because an array with Length = 6,
            // has a maximum index value of 5. If we set i = to 6, (without error handling) the program will break.



            // Step 4
            // Create a list of strings where each item is unique
            // prompt user to input text; search list for matches with this text input
            // Create a loop that iterates through the list, and displays the index of the value that matches the user input
            // Add code to inform user if their search term does not match any list items
            // Add code to stop the loop once a match is found

            // instantiate and populate list with string values
            Console.WriteLine("\nDemo 4: \n");

            List<string> foodList = new List<string>();
            foodList.Add("Cookie");
            foodList.Add("Brownie");
            foodList.Add("Breakfast Sandwich");

            Console.WriteLine("We have a small snack menu as well. Type the name of one of these snacks to add to your cart.");
            for (int i = 0; i < foodList.Count; i++)
            {
                Console.WriteLine(foodList[i]);
            }

            string foodInput = Console.ReadLine();

            for (int i = 0; i < foodList.Count; i++)
            {
                if (foodInput == foodList[i])
                {
                    Console.WriteLine("The list index for that item is " + i);                     
                    break;       //This exists the loop as soon as a matching record is found
                }
                else if (i == (foodList.Count - 1) && (foodInput != foodList[i]))     //if the index is at its maximum value and no matching record has been found, print the not-found message.
                {
                    Console.WriteLine("We're sorry, we can't find that item.");
                }
            }
            // Demo 5
            // Create a list of strings with at least two identical values
            // Ask user to search for text in the list
            // Create loop that iterates through list, displays indices of items matching user text
            // Inform user if user-given text is not in the list

            Console.WriteLine("\nDemo 5: \n");
            List<string> baristaList = new List<string>(); // instantiate list of strings, add redundant values
            baristaList.Add("John");
            baristaList.Add("Emily");
            baristaList.Add("John");
            baristaList.Add("John");
            baristaList.Add("Emily");
            baristaList.Add("Sara");
            Console.WriteLine("Welcome to the coffee shop roster wizard. \nHere is your store's current barista roster:");
            
            // display the list for the user
            for (int i = 0; i < baristaList.Count; i++)
            {
                Console.WriteLine(baristaList[i]);
            }
            Console.WriteLine("Type the name of a barista to see their roster ID.");
            string baristaInput = Console.ReadLine();
            
            // declare integer variable, to hold the number of matches found in the list
            int matchTotal = 0;
            
            // this for loop writes positive matches between user-text and list values to the console.
            // the output we want is the list index of each match.
            // The index of each matching value is represented by [ i ]

            for (int i = 0; i < baristaList.Count; i ++) //iterate through every value
            {
                if (baristaInput == baristaList[i])      //if user-text matches list item...
                {
                    Console.WriteLine("Barista " + baristaList[i] + " has ID " + i);   //write a readable phrase about the index value of the matching item
                    matchTotal++;  //for every match, increment the value of the matchTotal variable
                } 
            }

            // outside our for loop, check the value of matchTotal.
            // a zero value means no matches were found after iterating through every list item.
            // a non-zero value means matches were found.
            // The "barista not found" message will only write to console if zero matches were found.

            if (matchTotal == 0)
            {
                Console.WriteLine("Barista " + baristaInput + " not found.");
            }

            // Demo 6
            // Create a list of strings with at least two identical values
            // Create a foreach loop that displays a message showing the string, and whether it has already appeared in the list
            // This functionality will show the first instance of each duplicate value as unique, with redundant values that follow flagged as duplicates
            

            Console.WriteLine("\nDemo 6: \n");

            //Instantiate list of strings
            List<string> managerNamesList = new List<string>() { "Brad", "Greg", "Brad", "Greg", "Brian", "Brian", "Katherine" };
            
            //Instantiate empty list. The first instance of each value will be added to this list in a for loop
            List<string> managerDuplicatesList = new List<string>();
            
            //Declare string variable, to hold a suffix phrase, flagging values as unique or duplicate
            string managerSuffix;
                        
            Console.WriteLine("Welcome to the coffee shop management portal.\nHere is the current manager roster:\nNOTE: list may contain duplicates. Redundant values have been flagged.");
            
            // foreach loop iterates through every value in managerNamesList
            foreach (string manager in managerNamesList)
            {
                // if a value in the first list is not contained in the empty list,
                // the flag variable, managerSuffix, is set to "item is unique."
                // the current list value in managerNamesList is then added to the second list, managerDuplicatesList
                // The result then writes to the console.
                if (!(managerDuplicatesList.Contains(manager)))
                {
                    managerSuffix = (" - item is unique");
                    managerDuplicatesList.Add(manager);
                    Console.WriteLine(manager + managerSuffix);
                }

                // the else if block only runs if the if block evaluates to false,
                // which in this case, means the current value in the first list is also contained in the duplicate list.
                // if a value is present in both lists, the flag variable is set to "item is a duplicate."
                // The result then writes to the console.
                else if (managerDuplicatesList.Contains(manager))
                {
                    managerSuffix = (" - item is a duplicate");
                    Console.WriteLine(manager + managerSuffix);
                }
                
            }
            Console.Read();

        }
    }
}

using System;


namespace Do_While_Demo
{
    class Program
    {
        static void Main()
        {
            // while loop       - increment num1 until it equals num2
            int num1 = 0;
            int num2 = 10;
            

            while (num1 < num2)
            {
                Console.WriteLine(num1);
                num1 ++;
            }
            Console.WriteLine("both numbers now equal 10");
            


            // do while loop   - decrement num3 until it equals num4. For demonstration, initial values are set to be equal.
            int num3 = 11;             //run the loop with these values first. Increase the value of num3 to see more iterations of the do while loop.
            int num4 = 11;

            do
            {
                Console.WriteLine("decrementing num3");       // the do block will be executed, even though num3 is already equal to num4
                num3--;                        // this is the advantage over a simple while loop. The console will print the string in the do block, even though (num3 > num4) is never true. 
            }                                  // if a true statement is given immediately to a while loop that runs on an expecation that initial values will be false, the loop will never run
            while (num3 > num4);               // the while component of a do while loop will restart the do block if the while conditions are true. Here num3 is never greater than num4, so it never repeats.

            Console.WriteLine("both numbers now equal 11");  //this string is outside of the do while loop, so it will write only after the loop is completed.

            Console.Read();
        }
    }
}

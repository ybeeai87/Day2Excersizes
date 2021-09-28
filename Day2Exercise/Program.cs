using System;

namespace Day2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Write out a loop (for loop preferred) that goes from 0 - 100.
            if the number is even, display that number.
            if the number is odd, don't display that number*/
            for (int i = 0; i <= 100; i++)
            {
               
                if ( i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            /* Create a bool variable named runProgram = true
            Create a while loop that uses runProgram as the condition
            inside the loop ask if they want to continue looping.
            if yes then loop again
            if no stop loop*/
            bool runProgram = true;

            while(runProgram)
            {
                

                Console.WriteLine("Do you want to continue looping? (y/n)");
                string choice = Console.ReadLine();
                if (choice == "n")
                {
                    runProgram = false;
                }


            }
            /* Create a variable called sum. Its an int and starts at 0
            create a for loop that starts at 0 and goes up to 5
            as you are looping, Add the values to sum
            after the loop, display the sum
            (hint: it should equal out to 15 at the end) */

            int sum = 0;
            for (int i = 0; i <= 5; i++)
            {
                //sum = sum + i
                sum += i;
                
            }
            Console.WriteLine(sum);



        }
    }
}

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

        }
    }
}

﻿namespace COMP003A.LectureActivity3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Control Statements Demo!\n");

            int range; // The range of numbers to iterate through
            // Get the range of numbers to iterate through
            while (true)
            {
                // try-catch block to handle invaild input
                try
                {
                    // Prompt the user to enter a positive integer
                    Console.Write("Enter a positive integer to iterate through: ");
                    // Parse the input to an integer
                    range = int.Parse(Console.ReadLine());
                    // check if the number is positive
                    if (range <= 0) throw new Exception("Number must be positive.");
                    break;
                }
                catch (Exception ex)
                {
                    // Display an error message and prompt the user to try again
                    Console.WriteLine($"Invalid input: {ex.Message}\nPlease try again.\n");
                }
            }

            // Get the user's preferences for skipping and terminating the loop
            Console.Write("Would you like to skip a number?");
            // Convert the response to lowercase to make it case-insensitive
            string skipResponse = Console.ReadLine().ToLower();
            // Initalize the skip number to 0
            int skipNumber = 0;
            // Check if the user wants to skip a number
            if (skipResponse == "yes")
            {
                // Prompt the user to enter the number to skip
                Console.Write("Enter the number to skip");
                // Parse the input to an integer
                skipNumber = int.Parse(Console.ReadLine());
            }

            
        }
    }
}

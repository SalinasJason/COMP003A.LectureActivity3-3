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
            Console.Write("Would you like to skip a number? (yes/no): ");
            // Convert the response to lowercase to make it case-insensitive
            string skipResponse = Console.ReadLine().ToLower();
            // Initalize the skip number to 0
            int skipNumber = 0;
            // Check if the user wants to skip a number
            if (skipResponse == "yes")
            {
                // Prompt the user to enter the number to skip
                Console.Write("Enter the number to skip: ");
                // Parse the input to an integer
                skipNumber = int.Parse(Console.ReadLine());
            }

            // Get the user's preferences for terminating the loop
            Console.Write("Would you like to terminate the loop at a specific number? (yes/no): ");
            // Convert the response to lowercase to make it case-insensitive
            string terminateResponse = Console.ReadLine().ToLower();
            // Initialize the termination number to 0
            int terminateNumber = 0;
            // Check if the user wants to terminate the loop
            if (terminateResponse == "yes")
            {
                // Prompt the user to enter the termination number
                Console.Write("Enter the termination number: ");
                // Parse the input to an integer
                terminateNumber = int.Parse(Console.ReadLine());
            }

            // Display the output
            Console.WriteLine("\nOutput:");
            // iterate through the range of numbers
            for (int i = 1; i <= range; i++)
            {
                // Check if the current number is the number to skip
                if (i == skipNumber)
                {
                    continue; // Skip the specified number
                }

                // Check if the current number is the number to terminte at
                if (i == terminateNumber)
                {
                    // Display a message and break out of the loop
                    Console.WriteLine($"Loop terminated at number {terminateNumber}.");
                    break; // Terminate the loop
                }

                // Display the current number
                Console.WriteLine(i);
            }
        }
    }
}

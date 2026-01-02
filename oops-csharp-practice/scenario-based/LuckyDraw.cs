using System;

class LuckyDraw
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to the lucky draw");
        bool flag = true; // Control variable for the menu loop

        // Main menu loop
        while (flag)
        {
            // Show menu options
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Draw a Lucky Number");
            Console.WriteLine("2. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine()); // Read user choice

            switch (choice)
            {
                case 1:
                    // Prompt user to enter a lucky number
                    Console.Write("Enter your lucky number: ");
                    int num = Convert.ToInt32(Console.ReadLine());

                    // Check for valid input
                    if (num <= 0)
                    {
                        Console.WriteLine("Invalid Number");
                        continue;
                    }
                    // Check if number is divisible by both 3 and 5
                    if (num % 3 == 0 && num % 5 == 0)
                    {
                        Console.WriteLine("Congratulations! You are the lucky winner");
                    }
                    else
                    {
                        Console.WriteLine("Better luck next time");
                    }
                    break;
                case 2:
                    // Exit the program
                    flag = false;
                    Console.WriteLine("Thank you for visiting");
                    break;
                default:
                    // Handle invalid menu choice
                    Console.WriteLine("Invalid menu");
                    break;
            }
        }
    }
}
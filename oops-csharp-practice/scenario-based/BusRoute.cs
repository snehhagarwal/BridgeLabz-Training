using System;

class BusRouter
{
    static void Main(string[] args)
    {
        double totalDistance = 0; // Stores the total distance travelled
        bool onBus = true; // Control variable for the menu loop

        // welcome message
        Console.WriteLine("Welcome to the Bus Route Tracker");

        // Main menu loop
        while (onBus)
        {
            // Show menu options
            Console.WriteLine("\nMenu: ");
            Console.WriteLine("1. Add Distance for next stop: ");
            Console.WriteLine("2. View Total Distance: ");
            Console.WriteLine("3. Get Off the Bus: ");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine()); // Read user choice

            switch (choice)
            {
                case 1:
                    // Add distance for the next stop
                    Console.Write("Enter the distance: ");
                    double dist = Convert.ToDouble(Console.ReadLine());

                    if (dist > 0)
                    {
                        totalDistance += dist;
                        Console.WriteLine("Distance added. Total Distance: " + totalDistance);
                    }
                    else
                    {
                        Console.WriteLine("Distance must be greater than zero");
                    }
                    break;
                case 2:
                    // Display total distance travelled so far
                    Console.WriteLine("Total Distance travelled: " + totalDistance);
                    break;
                case 3:
                    // Ask user if they want to get off the bus
                    Console.Write("Want to get off the bus? ");
                    string cnfrm = Console.ReadLine().ToLower();

                    if (cnfrm == "yes")
                    {
                        onBus = false;
                        Console.WriteLine("You got off the bus");
                        Console.WriteLine("Distance travelled: " + totalDistance);
                    }
                    else
                    {
                        Console.WriteLine("Continue your journey");
                    }
                    break;
                default:
                    // Handle invalid menu choice
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }

        // Farewell message
        Console.WriteLine("Thank you");
    }
}
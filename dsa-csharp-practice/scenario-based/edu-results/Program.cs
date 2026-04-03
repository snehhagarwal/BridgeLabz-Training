using System;

class Program
{
    static void Main()
    {
        // Rank manager
        RankManager manager = new RankManager();
        int choice;

        do
        {
            // Menu
            Console.WriteLine("==== EduResults – Rank Sheet Generator ====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Generate Rank List");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            // Input
            choice = Convert.ToInt32(Console.ReadLine());

            // Selection
            switch (choice)
            {
                case 1:
                    manager.AddStudent();
                    break;

                case 2:
                    manager.GenerateRankList();
                    break;

                case 3:
                    Console.WriteLine("Exiting system...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }

        } while (choice != 3); // Loop
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        // Create manager
        CallLogManager manager=new CallLogManager();

        // User choice
        int choice;

        do
        {
            Console.WriteLine("Customer Service System");
            Console.WriteLine("1.Add Call Log");
            Console.WriteLine("2. Search Logs by Keyword");
            Console.WriteLine("3. Filter Logs by Time Range");
            Console.WriteLine("4. Exit");

            Console.Write("Enter choice: ");
            choice=Convert.ToInt32(Console.ReadLine());   // Read choice

            switch (choice)
            {
                case 1:
                    manager.AddCallLog();  // Add log
                    break;
                case 2:
                    manager.SearchByKeyword();   // Search log
                    break;
                case 3:
                    manager.FilterByTime();     // Filter log
                    break;
                case 4:
                    Console.WriteLine("Exit the program");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");  // Wrong input
                    break;
            }
        }while(choice!=4);   // Loop until exit
    }
}
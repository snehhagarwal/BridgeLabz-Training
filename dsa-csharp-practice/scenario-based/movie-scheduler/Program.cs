using System;

class Program
{
    static void Main(string[] args)
    {
        IMovieOperations manager = new Manager();
        int choice;

        do
        {
            Console.WriteLine("Cinema Time Menu");
            Console.WriteLine("1. Add Movie");
            Console.WriteLine("2. Display All Movies");
            Console.WriteLine("3. Search Movie");
            Console.WriteLine("4. Generate Report");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                   Console.Write("Enter movie titl: ");
                   string title=Console.ReadLine();

                   Console.Write("Enter show time: ");
                   string time=Console.ReadLine();

                   manager.Add(title,time);
                   break;
                case 2:
                   Console.WriteLine("All Movies: ");
                   manager.DisplayAll();
                   break;
                case 3:
                   Console.Write("Enter keyword to search: ");
                   string keyword=Console.ReadLine();
                   manager.Search(keyword);
                   break;
                case 4:
                   manager.GenerateReport();
                   break;
                case 5:
                   Console.WriteLine("Exiting the program");
                   break;
                default:
                   Console.WriteLine("Invalid Choice");
                   break;
            }
        }while(choice!=5);

        
    }
}
using System;

class LibraryMenu
{
    private Library library;

    public LibraryMenu()
    {
        library = new Library();
    }

    public void ShowMenu()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== Library Menu =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Borrow Book");
            Console.WriteLine("3. Display Books by Genre");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();

                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    library.AddBook(genre, title, author);
                    break;

                case 2:
                    Console.Write("Enter Genre: ");
                    string borrowGenre = Console.ReadLine();

                    Console.Write("Enter Book Title: ");
                    string borrowTitle = Console.ReadLine();

                    library.BorrowBook(borrowGenre, borrowTitle);
                    break;

                case 3:
                    Console.Write("Enter Genre: ");
                    string displayGenre = Console.ReadLine();

                    library.DisplayGenre(displayGenre);
                    break;

                case 4:
                    Console.WriteLine("Exiting program");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 4);
    }
}

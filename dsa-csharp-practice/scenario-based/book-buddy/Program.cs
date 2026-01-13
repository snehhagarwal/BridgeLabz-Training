using System;

class Program
{
    static void Main()
    {
        BookUtility manager = new BookUtility(10);
        int choice;

        do
        {
            Console.WriteLine("Book Buddy");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Sort Books Alphabetically");
            Console.WriteLine("3. Search Books by Author");
            Console.WriteLine("4. Display All Books");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();

                    Console.Write("Enter author name: ");
                    string author = Console.ReadLine();

                    manager.Add(title, author);
                    Console.WriteLine("Book added successfully!");
                    break;

                case 2:
                    manager.SortBook();
                    Console.WriteLine("Books sorted alphabetically.");
                    break;

                case 3:
                    Console.Write("Enter author name to search: ");
                    string searchAuthor = Console.ReadLine();

                    string[] results = manager.SearchByAuthor(searchAuthor);

                    if (results.Length == 0)
                    {
                        Console.WriteLine("No books found for this author.");
                    }
                    else
                    {
                        Console.WriteLine("Books found:");
                        foreach (string book in results)
                        {
                            Console.WriteLine(book);
                        }
                    }
                    break;

                case 4:
                    Console.WriteLine("All books in bookshelf:");
                    string[] allBooks = manager.ExportBook();

                    if (allBooks.Length == 0)
                    {
                        Console.WriteLine("Bookshelf is empty.");
                    }
                    else
                    {
                        foreach (string book in allBooks)
                        {
                            Console.WriteLine(book);
                        }
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

        } while (choice != 5);
    }
}

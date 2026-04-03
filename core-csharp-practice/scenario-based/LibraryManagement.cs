using System;

class LibraryManagement
{
    //array to add the books and its details in a library
    static string[,] library = new string[5, 3];
    //count of books in the library
    static int bookcount = 0;
    static bool isLibrarian=false;

    static void Main(string[] args)
    {
        //select role in the beginning 
        SelectRole();
        //function to display the menu 
        ShowMenu();
    }

    static void SelectRole()
    {
        //selecting roles whether librarian or user
        Console.WriteLine("Select Role: ");
        Console.WriteLine("1. Librarian : ");
        Console.WriteLine("2. User: ");

        int choice = Convert.ToInt32(Console.ReadLine());

        //giving choice to the user
        if (choice == 1)
        {
            isLibrarian=true;
            Console.WriteLine("Logged in as Libranian.");
        }
        else
        {
            isLibrarian=false;
            Console.WriteLine("Logged in as User.");
        }

    }

    static void ShowMenu()
    {
        //take the choice from the user 
        int choice;

        do
        {
            //menu available

            Console.WriteLine("\n MENU FOR THE LIBRARY");

            //menu for librarian 
            if (isLibrarian)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2.Remove Book");
                Console.WriteLine("3. Search by Title");
                Console.WriteLine("4. Display  Book ");
                Console.WriteLine("5. Switch Role");
                Console.WriteLine("6. Exiting the program");
            }
            //menu for user 
            else
            {
                Console.WriteLine("1. Search by Title");
                Console.WriteLine("2. Display  Book ");
                Console.WriteLine("3. Checkout Book");
                Console.WriteLine("4. Switch Role");
                Console.WriteLine("5. Exiting the program");
            }

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            //switch case for menu driven program
            if (isLibrarian)
            {
                switch (choice)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        RemoveBook();
                        break;
                    case 3:
                        Search();
                        break;
                    case 4:
                        Display();
                        break;
                    case 5:
                        SelectRole();
                        choice=0;  //reset value to 0 
                        break;
                    case 6:
                        Console.WriteLine("Thank you for the visit.");
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
            else
            {
                switch (choice)
                {
                    case 1:
                        Search();
                        break;
                    case 2:
                        Display();
                        break;
                    case 3:
                        CheckOut();
                        break;
                    case 4:
                        SelectRole();
                        choice=0; //reset value to zero so that program runs 
                        break;
                    case 5:
                        Console.WriteLine("Thank you for the visit.");
                        break;
                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }

        } while ((isLibrarian && choice != 6) || (!isLibrarian && choice != 5));
    }

    //add function to add the details of the book in multi-dimensional array
    static void Add()
    {
        if (isLibrarian)
        {
            //edge case if book count greater than array size
            if (bookcount >= 5)
            {
                Console.WriteLine("The library is full no more books can be added");
                return;
            }

            //entering the details
            Console.Write("Enter the Title of the book: ");
            library[bookcount, 0] = Console.ReadLine();

            Console.Write("Enter the author of the book: ");
            library[bookcount, 1] = Console.ReadLine();

            library[bookcount, 2] = "Available";

            bookcount += 1; //increasing the book count
            Console.WriteLine("Book Added in the library");
        }
        else
        {
            //access denied if the user is not a librarian
            Console.WriteLine("Access Denied");
        }
    }

    static void RemoveBook()
    {
        if (isLibrarian)
        {
            //enter title to be removed
            Console.Write("Enter title to remove: ");
            string str = Console.ReadLine().ToLower();

            for (int i = 0; i < bookcount; i++)
            {
                if (library[i, 0].ToLower().Contains(str))
                {
                    for (int j = i; j < bookcount - 1; j++)
                    {
                        //adjusting the book list and its indexing 
                        library[j, 0] = library[j + 1, 0];
                        library[j, 1] = library[j + 1, 1];
                        library[j, 2] = library[j + 1, 2];
                    }

                    //decrementing the number of books
                    bookcount--;
                    Console.WriteLine("Book removed Successfully");
                    return;
                }
            }
            //book not in the library 
            Console.WriteLine("Book not found");
        }
        else
        {
            Console.WriteLine("Access Denied");
        }
    }

    //search function of a part is only written 
    static void Search()
    {

        Console.Write("Enter part of the title: ");
        string str = Console.ReadLine().ToLower(); //converting to lower case 

        //variable to check if book is there or not 
        bool available = false;

        for (int i = 0; i < bookcount; i++)
        {
            //checking the part is in the title or not 
            if (library[i, 0].ToLower().Contains(str))
            {
                Console.WriteLine(library[i, 0] + " is written by " + library[i, 1] + " it is " + library[i, 2]);
                available = true;
            }
        }

        //if the book is only not available
        if (!available)
        {
            Console.WriteLine("Book not found.");
        }
    }

    //displaying the list of books
    static void Display()
    {
        Console.WriteLine("\n Book List");

        //iterate the array
        for (int i = 0; i < bookcount; i++)
        {
            Console.WriteLine(i + 1 + ". " + library[i, 0] + " by " + library[i, 1] + " it is " + library[i, 2]);
        }
    }

    static void CheckOut()
    {
        //user data to be taken 
        Console.Write("Enter title of the book to checkout: ");
        string str = Console.ReadLine().ToLower();

        //variable to find whether book can be found or not 
        bool found = false;

        //iterating the array
        for (int i = 0; i < bookcount; i++)
        {
            //checking the title 
            if (library[i, 0].ToLower().Contains(str))
            {
                found = true;
                if (library[i, 2] == "Available")
                {
                    library[i, 2] = "Not Available"; //changing the status 
                    Console.WriteLine("Book Checked Out Successfully");
                }
                else
                {
                    Console.WriteLine("Book is already checked out");
                }
                return;
            }
        }

        //if book found in library
        if (!found)
        {
            Console.WriteLine("Book is not in the library");
        }
    }

}
using System;

// Represents a node in the library doubly linked list
class BookNode
{
    public int Id;
    public string Title, Author;
    public bool Available;
    public string Genre;
    public BookNode next, prev;
}

// Manages the library using a doubly linked list
class Library
{
    BookNode head;

    // Adds a new book to the front of the list
    public void AddAtBeginning(int id, string title, string author, string genre)
    {
        BookNode node = new BookNode
        {
            Id = id,
            Title = title,
            Author = author,
            Genre = genre,
            Available = true
        };

        if (head == null)
        {
            head = tail = node;
            return;
        }

        node.next = head;
        head.prev = node;
        head = node;
    }

    // Add book at end
    public void AddAtEnd(int id, string title, string author, string genre)
    {
        BookNode node = new BookNode
        {
            Id = id,
            Title = title,
            Author = author,
            Genre = genre,
            Available = true
        };

        if (head == null)
        {
            head = tail = node;
            return;
        }

        tail.next = node;
        node.prev = tail;
        tail = node;
    }

    // Add book at specific position
    public void AddAtPosition(int pos, int id, string title, string author, string genre)
    {
        if (pos == 1)
        {
            AddAtBeginning(id, title, author, genre);
            return;
        }

        BookNode temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null || temp == tail)
        {
            AddAtEnd(id, title, author, genre);
            return;
        }

        BookNode node = new BookNode
        {
            Id = id,
            Title = title,
            Author = author,
            Genre = genre,
            Available = true
        };

        node.next = temp.next;
        node.prev = temp;
        temp.next.prev = node;
        temp.next = node;
    }

    // Remove book by ID
    public void RemoveById(int id)
    {
        BookNode temp = head;

        while (temp != null)
        {
            if (temp.Id == id)
            {
                if (temp == head)
                {
                    head = head.next;
                    if (head != null) head.prev = null;
                }
                else if (temp == tail)
                {
                    tail = tail.prev;
                    tail.next = null;
                }
                else
                {
                    temp.prev.next = temp.next;
                    temp.next.prev = temp.prev;
                }
                return;
            }
            temp = temp.next;
        }
    }

    // Search by Title
    public void SearchByTitle(string title)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                DisplayBook(temp);
                return;
            }
            temp = temp.next;
        }
        Console.WriteLine("Book not found");
    }

    // Search by Author
    public void SearchByAuthor(string author)
    {
        BookNode temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Author == author)
            {
                DisplayBook(temp);
                found = true;
            }
            temp = temp.next;
        }

        if (!found)
            Console.WriteLine("No books found by this author");
    }

    // Update availability status
    public void UpdateAvailability(int id, bool status)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Id == id)
            {
                temp.Available = status;
                return;
            }
            temp = temp.next;
        }
    }

    // Display all books forward
    public void DisplayForward()
    {
        BookNode temp = head;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.next;
        }
    }

    // Display all books reverse
    public void DisplayReverse()
    {
        BookNode temp = tail;
        while (temp != null)
        {
            DisplayBook(temp);
            temp = temp.prev;
        }
    }

    // Counts and prints the total number of books
    public void Count()
    {
        int count = 0;
        BookNode temp = head;
        while (temp != null)
        {
            count++;
            temp = temp.next;
        }
        Console.WriteLine("Total Books: " + count);
    }

    private void DisplayBook(BookNode b)
    {
        Console.WriteLine(
            b.Id + " | " +
            b.Title + " | " +
            b.Author + " | " +
            b.Genre + " | " +
            (b.Available ? "Available" : "Issued")
        );
    }
}

// Main class to demonstrate the library system
class LibraryMain
{
    static void Main(string[] args)
    {
        Library lib = new Library();
        // Add books
        lib.AddAtBeginning(1, "DSA", "CLRS", "Education");
        lib.AddAtEnd(2, "Java", "Herbert Schildt", "Programming");
        lib.AddAtEnd(3, "Python", "Guido", "Programming");

        // Add at position
        lib.AddAtPosition(2, 4, "C#", "MS", "Programming");

        Console.WriteLine("\nAll Books (Forward):");
        lib.DisplayForward();

        Console.WriteLine("\nAll Books (Reverse):");
        lib.DisplayReverse();

        Console.WriteLine("\nSearch by Title:");
        lib.SearchByTitle("Java");

        Console.WriteLine("\nSearch by Author:");
        lib.SearchByAuthor("Guido");

        Console.WriteLine("\nUpdating Availability:");
        lib.UpdateAvailability(2, false);
        lib.DisplayForward();

        Console.WriteLine("\nRemoving Book ID 1:");
        lib.RemoveById(1);
        lib.DisplayForward();

        Console.WriteLine();
        lib.CountBooks();
    }
}
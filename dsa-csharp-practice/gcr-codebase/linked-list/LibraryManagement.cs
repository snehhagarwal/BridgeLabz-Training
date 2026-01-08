using System;

// Represents a node in the library doubly linked list
class BookNode
{
    public int Id;
    public string Title,Author;
    public bool Available;
    public BookNode next,prev;
}

// Manages the library using a doubly linked list
class Library
{
    BookNode head;

    // Adds a new book to the front of the list
    public void Add(int id,string title,string author)
    {
        BookNode node=new BookNode{Id=id,Title=title,Author=author,Available=true};
        node.next=head;
        if (head != null)
        {
            head.prev=node;
        }
        head=node;
    }

    // Counts and prints the total number of books
    public void Count()
    {
        int count=0;
        BookNode temp=head;
        while (temp != null)
        {
            count++;
            temp=temp.next;
        }
        Console.WriteLine("Total Books: " + count);
    }
}

// Main class to demonstrate the library system
class LibraryMain
{
    static void Main(string[] args)
    {
        Library lib=new Library();
        lib.Add(1,"Java","MS");
        lib.Add(2,"DSA","CLRS");
        lib.Count();
    }
}
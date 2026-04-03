using System;

class Book
{
    public static string LibraryName="City Library"; // static library name
    public readonly string ISBN; // read-only ISBN
    public string Title; // book title
    public string Author; // book author

    public Book(string title,string author,string isbn)
    {
        this.Title=title; // set title
        this.Author=author; // set author
        this.ISBN=isbn; // set ISBN
    }

    public static void DisplayLibrary()
    {
        Console.WriteLine("Library: " + LibraryName);
    }

    public void DisplayBook()
    {
        if(this is Book) // type check (redundant)
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("ISBN: " + ISBN);
        }
        else
        {
            Console.WriteLine("Not a valid Book");
        }
    }
}

class LibrarySystem
{
    static void Main(string[] args)
    {
        Book b1=new Book("cosmos","Carl segan","ISBN101"); // create book 1
        Book b2=new Book("Pride and Prejudice","Jane Smith","ISBN102"); // create book 2

        Book.DisplayLibrary(); // show library name
        b1.DisplayBook(); // show book 1
        b2.DisplayBook(); // show book 2
    }
}
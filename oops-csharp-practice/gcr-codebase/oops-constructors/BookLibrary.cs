using System;

class Book
{
    public string ISBN;
    public string title;
    private string author;

    //default constructor
    public Book(){}

    //parameterized constructor
    public Book(string isbn,string title,string author)
    {
        ISBN=isbn;
        this.title=title;
        this.author=author;
    }
 
    //setting author
    public void SetAuthor(string author)
    {
        this.author=author;
    }

    //getting author
    public string GetAuthor()
    {
        return author;
    }
}

class EBook : Book
{
    public EBook(string isbn,string title,string author)
    {
        ISBN=isbn;
        this.title=title;
        SetAuthor(author);
    }

    public void Display()
    {
        Console.WriteLine("ISBN: " + ISBN);
        Console.WriteLine("The title is: " + title);
        Console.WriteLine("The author is: " + GetAuthor());
    }
}

class BookLibrary
{
    static void Main()
    {
        Console.Write("Enter ISBN: ");
        string isbn = Console.ReadLine();

        Console.Write("Enter Title: ");
        string title = Console.ReadLine();

        Console.Write("Enter Author Name: ");
        string author = Console.ReadLine();

        EBook ebook = new EBook(isbn, title, author);
        ebook.Display();
    }
}
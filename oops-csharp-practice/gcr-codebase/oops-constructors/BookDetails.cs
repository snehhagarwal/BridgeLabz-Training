using System;

class Book
{
    //variables
    public string Title;
    public string Author;
    public double Price;

    //unparametrized constructor
    public Book()
    {
        Title="Unknown";
        Author="Unknown";
        Price=0;
    }

    //parameterized constructor
    public Book(string title,string author,string price)
    {
        this.Title=title;
        this.Author=author;
        this.Price=price;
    }

    //function to display book details
    public void Display()
    {
        Console.WriteLine("Title: " + Title + " Author: " + Author + " Price: " + Price);
    }
}

class BookDetails
{
    static void Main(string[] args)
    {
        //entering the details of book
        Console.Write("Enter the title: ");
        string title=Console.ReadLine();

        Console.Write("Enter Author: ");
        string author=Console.ReadLine();

        Console.Write("Enter the price: ");
        double price=Convert.ToDouble(Console.ReadLine());

        //object creation and constructor call 
        Book b=new Book(title,author,price);
        b.Display();
    }
}
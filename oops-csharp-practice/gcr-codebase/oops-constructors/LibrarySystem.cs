using System;

class Book
{
    public string Title;
    public string Author;
    public double Price;
    public bool Available=true;

    
    public Book(string title,string author,double price)
    {
        this.Title=title;
        this.Author=author;
        this.Price=price;
        this.Available=true;
    }
    public void Borrow()
    {
        if (Available)
        {
            Available=false;
            Console.WriteLine("Book removed");
        }
        else
        {
            Console.WriteLine("Book not available");
        }
    }
}

class LibrarySystem
{
    static void Main(string[] args)
    {
        Book b=new Book();

        //take input from the user
        Console.Write("Enter the Title: ");
        b.Title=Console.ReadLine();

        Console.Write("Enter the Author: ");
        b.Author=Console.ReadLine();

        Console.Write("Enter the price: ");
        b.Price=Convert.ToDouble(Console.ReadLine());

        b.Borrow(); 
    }
}
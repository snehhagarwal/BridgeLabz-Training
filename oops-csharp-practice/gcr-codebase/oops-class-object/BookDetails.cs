using System;

class Book
{
    //all the entities
    public string Title;
    public string Author;
    public double Price;

    //method to print all the book details
    public void Display()
    {
        Console.WriteLine("\nBook Details: ");
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
    }

}

class BookDetails
{
    static void Main(string[] args)
    {
        //object creation 
        Book b=new Book();

        //input entered by the user
        Console.Write("Enter book title: ");
        b.Title=Console.ReadLine();

        Console.Write("Enter Author name: ");
        b.Author=Console.ReadLine();

        Console.Write("Enter book price: ");
        b.Price=Convert.ToDouble(Console.ReadLine());

        //method being called 
        b.Display();
    }
}
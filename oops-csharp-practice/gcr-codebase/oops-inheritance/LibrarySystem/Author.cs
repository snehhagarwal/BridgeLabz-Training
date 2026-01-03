using System;

class Author : Book
{
    public string Name;
    public string Bio;

    public void Display()
    {
        Console.WriteLine("Book Tile: " + Title);
        Console.WriteLine("Publication year of book: " + PublicationYear);
        Console.WriteLine("Author Name: " + Name);
        Console.WriteLine("Author Bio: " + Bio);


    }
}
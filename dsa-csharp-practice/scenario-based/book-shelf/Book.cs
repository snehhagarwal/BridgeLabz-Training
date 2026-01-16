using System;
using CustomLinkedList;

class Book
{
    public string Title { get; private set; }
    public string Author { get; private set; }

    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {Title}, Author: {Author}");
    }
}

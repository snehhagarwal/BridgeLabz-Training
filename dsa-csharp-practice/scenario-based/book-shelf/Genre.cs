using System;
using CustomLinkedList;

class Genre
{
    public string Name { get; private set; }
    private CustomLinkedList.CustomLinkedList books;

    public Genre(string name)
    {
        Name = name;
        books = new CustomLinkedList.CustomLinkedList();
    }

    public bool AddBook(Book book)
    {
        if (books.Exists(book.Title))
            return false;

        books.AddLast(book.Title);
        return true;
    }

    public bool RemoveBook(string title)
    {
        return books.Remove(title);
    }

    public void DisplayBooks()
    {
        books.Display();
    }
}

using System;
using System.Collections.Generic;
using CustomLinkedList;
class Library
{
    private List<Genre> genres;

    public Library()
    {
        genres = new List<Genre>();
    }

    private Genre FindGenre(string name)
    {
        return genres.Find(g => g.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
    }

    public void AddBook(string genreName, string title, string author)
    {
        Genre genre = FindGenre(genreName);

        if (genre == null)
        {
            genre = new Genre(genreName);
            genres.Add(genre);
        }

        if (genre.AddBook(new Book(title, author)))
            Console.WriteLine("Book added successfully.");
        else
            Console.WriteLine("Duplicate book not allowed.");
    }

    public void BorrowBook(string genreName, string title)
    {
        Genre genre = FindGenre(genreName);

        if (genre == null)
        {
            Console.WriteLine("Genre not found.");
            return;
        }

        if (genre.RemoveBook(title))
            Console.WriteLine("Book borrowed successfully.");
        else
            Console.WriteLine("Book not found.");
    }

    public void DisplayGenre(string genreName)
    {
        Genre genre = FindGenre(genreName);

        if (genre == null)
        {
            Console.WriteLine("Genre not found.");
            return;
        }

        Console.WriteLine($"\nBooks in {genreName}:");
        genre.DisplayBooks();
    }
}

using System;

public interface IBookShelf
{
    void Add(string title,string author);
    void SortBook();
    string[] SearchByAuthor(string author);
    string[] ExportBook();
}
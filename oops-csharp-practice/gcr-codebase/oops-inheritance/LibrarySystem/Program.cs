using System;

class Program
{
    static void Main(string[] args)
    {
        Author a=new Author();
        a.Title="Harry Potter";
        a.PublicationYear=2008;
        a.Name="JK Rowling";
        a.Bio="Sci-fi series around a magical boy";

        a.Display();
    }
}
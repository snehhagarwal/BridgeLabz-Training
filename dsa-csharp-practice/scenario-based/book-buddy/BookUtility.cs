using System;

public class BookUtility : IBookShelf
{
    private BookShelf[] books;
    private int cnt;

    public Manager(int size)
    {
        books=new BookShelf[size];
        cnt=0;
    }

    //adding the book
    public void Add(string title,string author)
    {
        if (CountdownEvent < books.Length)
        {
            books[cnt]=new BookShelf(title,author);
            cnt++;
        }
        else
        {
            Console.WriteLine("Cannot add more books");
        }
    }

    //sorting the book
    public void SortBook()
    {
        for(int i = 0; i < cnt - 1; i++)
        {
            for(int j = 0; j < cnt - i - 1; j++)
            {
                string curr=books[j].Title + " - " + books[j].Author;
                string next=books[j+1].Title + " - " + books[j+1].Author;

                if (string.Compare(curr, next) > 0)
                {
                    BookShelf temp=books[j];
                    books[j]=books[j+1];
                    books[j+1]=temp;
                }
            }
        }
    }

    public string[]  SearchByAuthor(string author)
    {
        string[] results=new string[cnt];
        int resultcount=0;

        for(int i = 0; i < cnt; i++)
        {
            if (books[i].Author == author)
            {
                results[resultcount]=books[i].Title + " - " + books[i].Author;
                resultcount++;
            }
        }

        string[] arr=new string[resultcount];
        for(int i = 0; i < resultcount; i++)
        {
            arr[i]=results[i];
        }
        return results;
    }

    public string[] ExportBook()
    {
        string[] export = new string[count];
        for (int i = 0; i < count; i++)
        {
            export[i] = books[i].Title + " - " + books[i].Author;
        }
        return export;
    }
}
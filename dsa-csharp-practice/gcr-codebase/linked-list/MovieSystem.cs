using System;

// Represents a node in the movie doubly linked list
class MovieNode
{
    public string Title,Director;
    public int Year;
    public double Rating;
    public MovieNode next,prev;
}

// Manages the movie list using a doubly linked list
class MovieList
{
    MovieNode head,tail;
    // Adds a new movie to the end of the list
    public void Add(string title,string director,int year,double rating)
    {
        MovieNode node=new MovieNode{Title=title,Director=director,Year=year,Rating=rating};
        if (head == null)
        {
            head=tail=node;
            return;
        }
        tail.next=node;
        node.prev=tail;
        tail=node;
    }

    // Displays all movies from head to tail
    public void DisplayForward()
    {
        MovieNode temp=head;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " - " + temp.Rating);
            temp=temp.next;
        }
    }

    // Displays all movies from tail to head
    public void DisplayReverse()
    {
        MovieNode temp=head;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " - " + temp.Rating);
            temp=temp.next;
        }
    }

    // Updates the rating of a movie by title
    public void UpdateRating(string title,double rating)
    {
        MovieNode temp=head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating=rating;
                return;
            }
            temp=temp.next;
        }
    }
}

// Main class to demonstrate the movie system
class MovieMain
{
    static void Main(string[] args)
    {
        MovieList list=new MovieList();
        list.Add("Inception","Nolan",2010,9.0);
        list.Add("Interstellar","Nolan",2014,8.8);
        list.DisplayForward();
        list.UpdateRating("Inception",9.5);
        list.DisplayReverse();
    }
}
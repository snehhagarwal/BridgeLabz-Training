using System;

// Represents a node in the movie doubly linked list
class MovieNode
{
    public string Title, Director;
    public int Year;
    public double Rating;
    public MovieNode next, prev;
}

// Manages the movie list using a doubly linked list
class MovieList
{
    MovieNode head, tail;

    // Adds a new movie to the start of the list
    public void AddAtBeginning(string title, string director, int year, double rating)
    {
        MovieNode node = new MovieNode
        {
            Title = title,
            Director = director,
            Year = year,
            Rating = rating,
            next = head
        };

        if (head != null)
            head.prev = node;
        else
            tail = node;

        head = node;
    }

    // Adds a new movie to the end of the list
    public void Add(string title, string director, int year, double rating)
    {
        MovieNode node = new MovieNode { Title = title, Director = director, Year = year, Rating = rating };
        if (head == null)
        {
            head = tail = node;
            return;
        }
        tail.next = node;
        node.prev = tail;
        tail = node;
    }

    // Adds a new movie to the specified position in the list
    public void AddAtPosition(int pos, string title, string director, int year, double rating)
    {
        if (pos == 1)
        {
            AddAtBeginning(title, director, year, rating);
            return;
        }

        MovieNode temp = head;
        for (int i = 1; i < pos - 1 && temp != null; i++)
            temp = temp.next;

        if (temp == null)
        {
            Console.WriteLine("Invalid position");
            return;
        }

        MovieNode node = new MovieNode
        {
            Title = title,
            Director = director,
            Year = year,
            Rating = rating,
            next = temp.next,
            prev = temp
        };

        if (temp.next != null)
            temp.next.prev = node;
        else
            tail = node;

        temp.next = node;
    }


    // Displays all movies from head to tail
    public void DisplayForward()
    {
        MovieNode temp = head;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " - " + temp.Rating);
            temp = temp.next;
        }
    }

    // Displays all movies from tail to head
    public void DisplayReverse()
    {
        MovieNode temp = tail;
        while (temp != null)
        {
            Console.WriteLine(temp.Title + " - " + temp.Rating);
            temp = temp.prev;
        }
    }

    //removes movie by title
    public void RemoveByTitle(string title)
    {
        MovieNode temp = head;

        while (temp != null)
        {
            if (temp.Title == title)
            {
                if (temp.prev != null)
                    temp.prev.next = temp.next;
                else
                    head = temp.next;

                if (temp.next != null)
                    temp.next.prev = temp.prev;
                else
                    tail = temp.prev;

                return;
            }
            temp = temp.next;
        }
    }

    //serach by rating
    public void SearchByDirector(string director)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Director == director)
                Console.WriteLine(temp.Title);
            temp = temp.next;
        }
    }
    //search by rating
    public void SearchByRating(double rating)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Rating == rating)
                Console.WriteLine(temp.Title);
            temp = temp.next;
        }
    }


    // Updates the rating of a movie by title
    public void UpdateRating(string title, double rating)
    {
        MovieNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
            {
                temp.Rating = rating;
                return;
            }
            temp = temp.next;
        }
    }
}

// Main class to demonstrate the movie system
class MovieMain
{
    static void Main(string[] args)
    {
        MovieList list = new MovieList();

        // Add movies at end
        list.Add("Inception", "Nolan", 2010, 9.0);
        list.Add("Interstellar", "Nolan", 2014, 8.8);

        // Add movie at beginning
        list.AddAtBeginning("Titanic", "James Cameron", 1997, 8.5);

        // Add movie at specific position
        list.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.8);

        Console.WriteLine("\nMovies (Forward Order):");
        list.DisplayForward();

        Console.WriteLine("\nMovies (Reverse Order):");
        list.DisplayReverse();

        // Search operations
        Console.WriteLine("\nSearch by Director (Nolan):");
        list.SearchByDirector("Nolan");

        Console.WriteLine("\nSearch by Rating (8.5):");
        list.SearchByRating(8.5);

        // Update rating
        list.UpdateRating("Inception", 9.5);
        Console.WriteLine("\nAfter Updating Rating:");
        list.DisplayForward();

        // Remove movie by title
        list.RemoveByTitle("Avatar");
        Console.WriteLine("\nAfter Removing Avatar:");
        list.DisplayForward();
    }
}

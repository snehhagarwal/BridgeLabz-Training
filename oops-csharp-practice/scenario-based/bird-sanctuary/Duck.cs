using System; // System namespace

// Duck class inherits Bird, ISwimmable
public class Duck : Bird, ISwimmable
{
    // Constructor
    public Duck(string n,string c)
    {
        name=n;
        color=c;
    }

    // Swim method
    public void Swim()
    {
        Console.WriteLine("Duck is swimming");
    }
}
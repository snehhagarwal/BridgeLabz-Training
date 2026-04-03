using System; // System namespace
using System.IO.Compression; // Compression (not used)

// Seagull class inherits Bird, IFlyable, ISwimmable
public class Seagull : Bird, IFlyable, ISwimmable
{
    // Constructor
    public Seagull(string n,string c)
    {
        name=n;
        color=c;
    }

    // Fly method
    public void Fly()
    {
        Console.WriteLine("Seagull is flying");
    }

    // Swim method
    public void Swim()
    {
        Console.WriteLine("Seagull is swimming");
    }
}
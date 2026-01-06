using System;

// Penguin class inherits Bird and can swim
public class Penguin : Bird, ISwimmable
{
    // Constructor to set details
    public Penguin(string n,string c)
    {
        name=n;    // Assign name
        color=c;  // Assign color
    }
     // Swimming behavior
    public void Swim()
    {
        Console.WriteLine("Penguin is swimming"); // Display swimming action
    }
}
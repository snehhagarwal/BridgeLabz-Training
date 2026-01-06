using System;

// Sparrow class inherits Bird and can fly
public class Sparrow : Bird, IFlyable
{
    public Sparrow(string n,string c)    // Constructor to set details
    {
        name=n;    // Assign name
        color=c;   // Assign color
    }

    // Flying behavior
    public void Fly()
    {
        Console.WriteLine("Sparrow is flying");   // Display flying action
    }
}
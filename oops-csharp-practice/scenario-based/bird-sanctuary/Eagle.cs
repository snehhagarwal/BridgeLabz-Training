using System; // System namespace

// Eagle class inherits Bird, IFlyable
public class Eagle : Bird, IFlyable
{
    // Constructor
    public Eagle(string name,string color)
    {
        name=name;
        color=color;
    }

    // Fly method
    public void Fly()
    {
        Console.WriteLine("Eagle is flying");
    }
}
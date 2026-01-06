using System; // System namespace

// Bird base class
public class Bird
{
    protected string name; // bird name
    protected string color; // bird color
    // Constructor
    public Bird(string name,string color)
    {
        this.name=name;
        this.color=color;
    }

    // Display bird info
    public void Display()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Color: " + color);
    }
}
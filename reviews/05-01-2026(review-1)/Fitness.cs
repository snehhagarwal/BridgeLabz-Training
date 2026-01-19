
public abstract class Fitness
{

    public int Step
    {
        get; set;
    }
    public int calories
    {
        get; set;

    }
    public int height
    {
        get; set;

    }
    public int weight
    {
        get; set;

    }

    public virtual void Display()
    {
        Console.WriteLine("Steps taken by the user is " + Step);
        Console.WriteLine("Calories Intake Per Day: " + Calories);
        Console.WriteLine("Height of the user: " + height);
        Console.WriteLine("Weight of the user: " + weight);

    }
}
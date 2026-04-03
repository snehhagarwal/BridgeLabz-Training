using System;
class Calories : Fitness
{
    public override void CalculateCal()
    {
        CalBurnt = calories / 100;
        Console.WriteLine("The amount of calories burnt are " + CalBurnt);
    }
}
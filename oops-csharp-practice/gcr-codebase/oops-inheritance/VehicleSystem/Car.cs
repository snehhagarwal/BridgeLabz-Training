using System;

class Car : Vehicle
{
    public int seats;

    public override void Display()
    {
        Console.WriteLine("Car");
        Console.WriteLine("Seats capacity: " + seats);
    }
}
using System;

class Truck: Vehicle
{
    public int capacity;

    public override void Display()
    {
        Console.WriteLine("Truck");
        Console.WriteLine("Payload Capacity: " + capacity);
    }
}
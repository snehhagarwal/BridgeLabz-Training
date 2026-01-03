using System;

class Vehicle
{
    public int speed;
    public string fueltype;

    public virtual void Display()
    {
        Console.WriteLine("Max Speed: " + speed);
        Console.WriteLine("Fuel Type: "+ fueltype);
    }
}
using System;

public class PetrolVehicle : Vehicle, Refuelable
{
    public void Refuel()
    {
        Console.WriteLine("Petrol vehicle is refueling.");
    }
}
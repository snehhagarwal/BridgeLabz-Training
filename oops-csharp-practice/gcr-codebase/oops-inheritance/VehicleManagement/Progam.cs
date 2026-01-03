using System;

class Program
{
    static void Main(string[] args)
    {
        ElectricVehicle ev = new ElectricVehicle();
        ev.Model = "Tesla";
        ev.Speed = 180;
        ev.Charge();

        Console.WriteLine();

        PetrolVehicle pv = new PetrolVehicle();
        pv.Model = "Honda City";
        pv.Speed = 160;
        pv.Refuel();
    }
}

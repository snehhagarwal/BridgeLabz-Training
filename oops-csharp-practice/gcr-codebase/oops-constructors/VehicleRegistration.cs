using System;

class Vehicle
{
    //instance variable
    public string ownerName;
    public string vehicleType;

    //class variable
    public static double fee=5000;

    //parameterized constructor
    public Vehicle(string name,string vehicle)
    {
        this.ownerName=name;
        this.vehicleType=vehicle;
    }

    //instance method
    public void DisplayVehicle()
    {
        Console.WriteLine("The name of owner is: " + ownerName);
        Console.WriteLine("The type of vehicle is: " + vehicleType);
        Console.WriteLine("The Registration fee is: " + fee);
    }

    //class method
    public static void UpdateFee(double f)
    {
        fee=f;
    }
}

class VehicleRegistration
{
    static void Main(string[] args)
    {
        Vehicle v1=new Vehicle("John","Car");
        v1.DisplayVehicle();

        Vehicle.UpdateFee(5000);

        Console.WriteLine("After Fee update: ");
        v1.DisplayVehicle();
    }
}
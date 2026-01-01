using System;

class Vehicle
{
    public static double RegistrationFee=500;
    private static int vehicleCount=0;

    public readonly string RegistrationNumber;
    public string OwnerName;
    public string VehicleType;

    public Vehicle(string name,string type)
    {
        this.OwnerName=name;
        this.VehicleType=type;
        vehicleCount++;
        this.RegistrationNumber="REG"+ vehicleCount;
    }

    public static void UpdateFee(double fee)
    {
        RegistrationFee=fee;
        Console.WriteLine("Registration fee updated to: " + RegistrationFee);
    }

    public void Display()
    {
        if(this is Vehicle)
        {
            Console.WriteLine("Owner: " + OwnerName);
            Console.WriteLine("Vehicle Type: " + VehicleType);
            Console.WriteLine("Registration Number: " + RegistrationNumber);
            Console.WriteLine("Registration Fee: " + RegistrationFee);

        }
        else
        {
            Console.WriteLine("Not a valid vehicle object");
        }
    }
}
class VehicleSystem
{
    static void Main(string[] args)
    {
        Vehicle v1=new Vehicle("John","Car");
        Vehicle v2=new Vehicle("Olly","Bike");

        v1.Display();
        v2.Display();

        Vehicle.UpdateFee(600);
        v1.Display();
        v2.Display();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] arr=new Vehicle[1];
        Car c=new Car();
        c.VehicleId=1;
        c.DriverName="Ram";
        c.RatePerKm=15;

        arr[0]=c;

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Fare: " + arr[i].CalculateFee(10));
        }
    }
}
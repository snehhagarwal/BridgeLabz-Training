using System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] arr=new Vehicle[1];

        Car c=new Car();
        c.vehicleNumber="UP12CD5678";
        c.RentalRate=1000;

        arr[0]=c;

        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Rental Cost: " + arr[i].CalculateCost(3));

            if(arr[i] is IInsurable)
            {
                IInsurable ins=(IInsurable)arr[i];
                Console.WriteLine("Insurance: " + ins.CalculateInsurance());
            }
        }
    }
}
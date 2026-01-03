using System;

class Program
{
    static void Main(string[] args)
    {
        DeliveredOrder a=new DeliveredOrder();
        a.OrderId=101;
        a.Date="11-June-2025";
        a.TrackingNumber="TRK123";
        a.DeliveryDate="18-June-2025";

        Console.WriteLine(a.GetStatus());
    }
}
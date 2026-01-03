using System;

class Thermostat : Device
{
    public int Temp;
    public void Display()
    {
        Console.WriteLine("Device Id: " + DeviceId);
        Console.WriteLine("Status: " + Status);
        Console.WriteLine("Temperature: " + Temp);
    }
}
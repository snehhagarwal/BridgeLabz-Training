using System;

class Program
{
    static void Main(string[] args)
    {
        Thermostat t=new Thermostat();
        t.DeviceID=101;
        t.Status="On";
        t.Temp=22;

        t.Display();
    }
}
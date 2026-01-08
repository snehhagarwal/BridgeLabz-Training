using System;

class Light : Appliance
{
    public Light(string name)
    {
        SetName(name);
    }

    public override void TurnOn()
    {
        Console.WriteLine(name + " light is turned On.");
    }

    public override void TurnOff()
    {
        Console.WriteLine(name + " light is turned off.");
    }
}
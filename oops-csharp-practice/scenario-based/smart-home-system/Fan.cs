using System;

class Fan : Appliance
{
    public Fan(string name)
    {
        SetName(name);
    }

    public override void TurnOn()
    {
        Console.WriteLine(name + " fan is turned on");
    }

    public override void TurnOff()
    {
        Console.WriteLine(name + " fan is turned off");
    }
}
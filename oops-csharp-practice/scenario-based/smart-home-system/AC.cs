using System;

sealed class AC : Appliance
{
    public AC(string name)
    {
        SetName(name);
    }

    public override void TurnOn()
    {
        Console.WriteLine(name + " AC is turned on");
    }

    public override void TurnOn()
    {
        Console.WriteLine(name +  " AC is turned off");
    }
}
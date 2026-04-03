using System;

class MotorCycle : Vehicle
{
    public bool sidecar;
    public override void Display()
    {
        Console.WriteLine("MotorCycle");
        Console.WriteLine("Has Sidecar: " + sidecar);
    }
}
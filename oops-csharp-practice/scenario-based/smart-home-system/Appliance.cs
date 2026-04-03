using System;

abstract class Appliance : IControllable
{
    protected string name;
    public SetName(string applianceName)
    {
        name=applianceName;
    }
    public abstract void TurnOn();
    public abstract void TurnOff();
}
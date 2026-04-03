using System;
using System.ComponentModel.Design.Serialization;

public class Truck : Vehicle, IRentable
{
    // Initialize truck with number and rate
    public Truck(string num,double rate)
    {
        VehicleNumber=num;
        cost=rate;
    }

    // Calculate rent for days
    public double CalculateRent(int day)
    {
        return cost*day;
    }
}

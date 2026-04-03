using System;
using System.ComponentModel.Design.Serialization;

public class Car : Vehicle,IRentable
{
    // Initialize car with number and daily rate
    public Car(string num,double rate)
    {
        VehicleNumber=num;
        cost=rate;
    }

    // Calculate total rent for given number of days
    public double CalculateRent(int day)
    {
        return cost*day;
    }
}
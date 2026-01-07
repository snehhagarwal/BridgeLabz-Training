using System;

public class Car : Vehicle
{
    public override double CalculateFee(double distance)
    {
        return RatePerKm*distance;
    }
}
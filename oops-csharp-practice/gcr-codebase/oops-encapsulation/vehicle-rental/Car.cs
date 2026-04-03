using System;

public class Car : Vehicle, IInsurable
{
    public override double CalculateCost(int days)
    {
        return rentalRate*days;
    }

    public double CalculateInsurance()
    {
        return 500;
    }

    public string GetInsurance()
    {
        return "Car Insurance";
    }
}
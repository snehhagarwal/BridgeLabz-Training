using System;

public abstract class Vehicle
{
    private string vehicleNumber;
    private double rentalRate;

    public string VehicleNumber{get=>vehicleNumber;set=>vehicleNumber=value;}
    public double RentalRate{get=>rentalRate;set=>rentalRate=value;}

    public abstract double CalculateCost(int day);
}
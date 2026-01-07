using System;

public abstract class Vehicle
{
    private int vehicleId;
    private string driverName;
    private double ratePerKm;

    public int VehicleId{get=>vehicleId;set=>vehicleId=value;}
    public string DriverName{get=>driverName;set=>driverName=value;}
    public double RatePerKm{get=>ratePerKm;set=>ratePerKm=value;}

    public abstract double CalculateFee(double distance);
}
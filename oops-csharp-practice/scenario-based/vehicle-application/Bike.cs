using System;

public class Bike : Vehicle,IRentable
{
    // Constructor to set bike details
     public Bike(string num,double rate)
     {
         VehicleNumber=num;  //vehicle number
         cost=rate;          //rent per day
     }

    // Calculates total rent
     public double CalculateRent(int day)
     {
         return cost*day;
     }
}
      

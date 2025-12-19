using System;

class VolumeOfEarth{
    static void Main(){

        //radius in km
        double radius=6378;
        double pi=Math.PI;

        //volume in km
        double volume = (4.0/3.0)*pi*Math.Pow(radius,3);

        //volume in miles
        double volumeMiles= volume/Math.Pow(1.6,3);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volume+ " and cubic miles is " + volumeMiles);
    }
}
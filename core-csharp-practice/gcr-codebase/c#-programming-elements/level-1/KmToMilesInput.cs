using System;

class KmToMilesInput{
    static void Main(){
        //input from user
        Console.WriteLine("Enter the distance in km: ");
        double km=Convert.ToDouble(Console.ReadLine());

        //convert in miles
        double miles=km/1.6;

        Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
    }
}
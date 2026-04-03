using System;

class KmToMiles{
    public static void Main(string[] args){

        Console.WriteLine("Enter the distance in km: ");
        double km=double.Parse(Console.ReadLine()); //take input as km 

        //conversion to miles
        double miles=km*0.621371; 
        
        //printing statement
        Console.WriteLine("The distance in Miles is: "+ miles);

    }
}
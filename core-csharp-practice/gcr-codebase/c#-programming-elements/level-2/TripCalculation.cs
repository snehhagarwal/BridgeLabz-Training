using System;

class TripCalculation{
    static void Main(string[] args){

        //taking all inputs from the user
        Console.WriteLine("Enter the name: ");
        string name=Console.ReadLine();
        
        Console.WriteLine("Enter from city: ");
        string fromcity=Console.ReadLine();

        Console.WriteLine("Enter via city: ");
        string viaCity=Console.ReadLine();

        Console.WriteLine("Enter the destination city: ");
        string destination=Console.ReadLine();

        Console.WriteLine("Enter the distance from source to via");
        double dist=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the distance via to destination");
        double dist2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time: ");
        double time=Convert.ToDouble(Console.ReadLine());

        //calculating the total distance
        double totaldist=dist+dist2;
        //calculating the speed
        double speed=totaldist/time;

        Console.WriteLine("The results of the trip are: " + totaldist + ", " + time + ", " + speed);

    }
}
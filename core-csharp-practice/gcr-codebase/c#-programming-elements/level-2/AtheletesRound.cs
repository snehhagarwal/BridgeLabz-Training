using System;

class AtheletesRound{
    static void Main(string[] args){

        //taking sides as input from the user
        Console.WriteLine("Enter the 1st number: ");
        double s1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number: ");
        double s2=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the 3rd number: ");
        double s3=Convert.ToDouble(Console.ReadLine());

        //perimeter calculation
        double perimeter=s1+s2+s3;
        //calculate the distance
        double dist=5000;
        //calculating rounds
        double rounds=dist/perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + rounds + " to complete 5 km");
    }
}
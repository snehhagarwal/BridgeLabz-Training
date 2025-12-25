using System;

class AtheleteRounds
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter 1st side: ");
        double s1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the 2nd side");
        double s2=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the 3rd side");
        double s3=Convert.ToDouble(Console.ReadLine());
        
        //function call 
        double rounds=func(s1,s2,s3);
    }

    static double func(double a,double b,double c)
    {
        //calculation 
        double perimeter=a+b+c;
        return 5000/perimeter;
    }
}
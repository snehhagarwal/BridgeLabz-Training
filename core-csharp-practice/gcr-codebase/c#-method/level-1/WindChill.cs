using System;
using System.Runtime.CompilerServices;

class WindChill
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the temperature: ");
        double temp=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the speed: ");
        double speed=Convert.ToDouble(Console.ReadLine());

        //function call
        double result=Calculate(temp,speed);

        Console.WriteLine("Wind Chill: " + result);
    }

    public static double Calculate(double temp,double speed)
    {
        //calculation 
        int val= 35.74+0.6215 * temp+(0.4275*temp-35.75) * Math.Pow(speed,0.16);
        return val;
    }
}
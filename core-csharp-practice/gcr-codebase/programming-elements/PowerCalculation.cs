using System;

class PowerCalculation{
    public static void Main(string[] args){

        Console.Write("Enter the base: ");
        double baseVal=double.Parse(Console.ReadLine()); //take base as input

        Console.Write("Enter the exponent: ");
        double exponent=double.Parse(Console.ReadLine()); //take exponent as input

        //power calculation
        double power=Math.Pow(baseVal,exponent);

        //printing the statement
        Console.WriteLine("The calculated power is: "+ power);
    }
}
using System;

class CelsiusToFahrenheit{
    static void Main(string[] args){

        //read input
        Console.WriteLine("Enter the temperature in Celsius");
        double celsius=double.Parse(Console.ReadLine()); //taking input as celsius

        //conversion formula
        double fahrenheit=(celsius*9/5)+32;

        //printing the statement
        Console.WriteLine("The temperature in Fahrenheit is: " + fahrenheit);

    }
}
using System;

class CelsiusToFahrenheit{
    static void Main(string[] args){
          Console.WriteLine("Enter the temp: ");
          double cel=Convert.ToDouble(Console.ReadLine());

          double fahrenheit=(cel*9/5)+32;

        Console.WriteLine("The " + cel + " Celsius is " + fahrenheit + " Fahrenheit");
    }
}
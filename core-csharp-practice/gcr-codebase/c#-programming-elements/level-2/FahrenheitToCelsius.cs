using System;

class FahrenheitToCelsius{
    static void Main(string[] args){

        //taking input 
        Console.WriteLine("Enter the temp in fahrenheit: ");
        double fahr=Convert.ToDouble(Console.ReadLine());

        //conversion to celsius
        double cel=(fahr-32)*5/9 ;

        //printing statement
        Console.WriteLine("The " + fahr + " Fahreheit is " + cel + " Celsius");
        
    }
}
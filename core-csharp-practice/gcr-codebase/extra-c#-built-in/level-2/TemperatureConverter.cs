using System;

class TemperatureConverter
{
    static void Main(string[] args)
    {
        //give the user choice
        Console.WriteLine("1. Celsius to Fahrenheit");
        Console.WriteLine("2. Fahrenheit to Celsius");
        //user selecting a choice
        Console.Write("Choose an option: ");
        int c=Convert.ToInt32(Console.ReadLine());

        //if choice 1
        if (c == 1)
        {
            Console.Write("Enter the temperature in celsius: ");
            double temp=Convert.ToDouble(Console.ReadLine());
            double f=func1(temp);
            Console.WriteLine("The temperature in Fahrenheit is: " + f);
        }
        //if choice 2
        else if (c == 2)
        { 
           Console.Write("Enter the temperature in fahrenheit: ");
           double temp=Convert.ToDouble(Console.ReadLine());
           double f=func2(temp);
           Console.WriteLine("The temperature in Celsius is: " + f);  
        }
    }

    //function for celsius to fahrenheit
    static double func1(double p)
    {
        return (p*9/5)+32;
    }

    //function for fahrenheit to celsius
    static double func2(double p)
    {
        return (p-32)*5/9;
    }
}
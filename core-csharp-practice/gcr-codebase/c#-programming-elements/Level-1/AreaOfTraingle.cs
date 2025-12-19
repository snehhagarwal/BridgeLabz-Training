using System;

class AreaOfTriangle{
    static void Main(){

        //take input from user
        Console.WriteLine("Enter the base: ");
        double baseval=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        //area calculation
        double area=0.5 * baseval *height;

        Console.WriteLine("The area of the triangle is " + area);

    }
}
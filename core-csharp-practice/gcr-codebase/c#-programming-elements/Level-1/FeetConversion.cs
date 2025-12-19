using System;

class FeetConversion{
    static void Main(){
        //distance in feet as input

        Console.WriteLine("Enter the distance in feet: ");
        double feet=Convert.ToDouble(Console.ReadLine());

        //conversion in yards
        double yards=feet/3;

        //conversion in miles
        double miles= yards/1760;

        Console.WriteLine("Distance in yards is " + yards + " and in miles is " + mile);
    }
}
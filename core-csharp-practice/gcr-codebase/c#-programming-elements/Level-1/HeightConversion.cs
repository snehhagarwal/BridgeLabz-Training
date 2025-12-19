using System;

class HeightConversion{
    static void Main(){

        //taking height in cm
        Console.WriteLine("Enter the height in cm: ");
        double cm=Convert.ToDouble(Console.ReadLine());

        //conversion in inch
        double inch=cm/2.54;
        
        //conversion in feet
        int feet=(int)(inches/12);

        //calculating remaining inches
        double remaining=inches%12;

        Console.WriteLine("Your heigth in cm is "+ cm + " while in feet is " + feet + " and inches is " + remaining);
    }
}
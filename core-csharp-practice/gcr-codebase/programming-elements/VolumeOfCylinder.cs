using System;

class VolumeOfCylinder{
    public static void Main(string[] args){

        Console.Write("Enter the radius of the cylinder: ");
        int radius=int.Parse(Console.ReadLine()); //taking radius as an input

        Console.Write("Enter the height of the cylinder: ");
        int  height=int.Parse(Console.ReadLine()); //taking height as an input

        //volume calculation
        double volume=Math.PI * Math.Pow(radius,2) * height;

        Console.Write("The volume of the cylinder is: " + volume);
    }
}
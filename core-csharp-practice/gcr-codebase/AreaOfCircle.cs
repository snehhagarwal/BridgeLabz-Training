using System;

class AreaOfCircle {
    static void Main(string[] args) {
        //read input
        Console.Write("Enter the radius of the circle: ");
        int radius = int.Parse(Console.ReadLine()); //take radius as input

        //formula to calculate the area
        double area = Math.PI * radius * radius;

        Console.WriteLine("The area of the circle is: " + area);
 
    }
}
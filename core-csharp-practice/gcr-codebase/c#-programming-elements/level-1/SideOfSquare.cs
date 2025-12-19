using System;

class SideOfSquare{
    static void Main(){
        //perimeter of the sqaure
        Console.WriteLine("Enter the perimter: ");
        double peri=Convert.ToDouble(Console.ReadLine());

        //side of sq
        double side=peri/4;

        Console.WriteLine("The length of the side is " + side + " whose perimeter is " + perimeter);
    }
}
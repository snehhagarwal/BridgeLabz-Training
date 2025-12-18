using System;

class PerimeterOfRectangle{
    public static void Main(string[] args){

        Console.WriteLine("Enter the length of the rectangle: ");
        int length=int.Parse(Console.ReadLine()); //taking length as an input

        Console.WriteLine("Enter the breadth of the rectangle: ");
        int breadth=int.Parse(Console.ReadLine());

        //calculating the perimeter
        int perimeter=2*(length+breadth);

        //printing the perimeter
        Console.Write("The perimeter of the rectangle is: "+ perimeter);

    }
}
using System;

class Radius
{
    //radius variable
    public double radius;

    //function for area
    public double CalculateArea()
    {
        return Math.PI*radius*radius;
    }

    //function for circumference
    public double CalculateCircumference()
    {
        return 2*Math.PI*radius;
    }
}

class Circle
{
    static void Main(string[] args)
    {
        //object creation
        Radius obj=new Radius();

       //taking input from the user
        Console.Write("Enter the radius of the circle: ");
        obj.radius=Convert.ToDouble(Console.ReadLine());

       //displaying all the operations
       Console.WriteLine("\nCircle Details: ");
       Console.WriteLine("The area of the circle is: "  + obj.CalculateArea());
       Console.WriteLine("The circumference of the circle is: " + obj.CalculateCircumference());        

    }
}
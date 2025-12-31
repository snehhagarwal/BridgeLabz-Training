using System;

class Circle
{
    
    public double Radius;

    //non-parameterized Constructor
    public Circle()
    {
        Radius=1;
    }

    //parameterized constructor
    public Circle(double radius)
    {
        Radius=radius;
    }

    //display functions
    public void Display()
    {
        Console.WriteLine("Radius: " + Radius);
        Console.WriteLine("Area: " + Math.PI*Radius*Radius);
    }
}

class CircleDetails
{
    static void Main(string[] args)
    {
        //take input from the users
        Console.Write("Enter Radius: ");
        double r=Convert.ToDouble(Console.ReadLine());

        //object creation 
        Circle c=new Circle();
        c.Display();
    }
}
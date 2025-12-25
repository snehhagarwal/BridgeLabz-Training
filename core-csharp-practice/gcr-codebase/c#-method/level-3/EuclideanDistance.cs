using System;

class EuclideanDistance
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter x1: ");
        double x1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y1: ");
        double y1=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter x2: ");
        double x2=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter y2: ");
        double y2=Convert.ToDouble(Console.ReadLine());

        double distance=dist(x1,y1,x2,y2);
        double[] line=linefunc(x1,y1,x2,y2);

        Console.WriteLine("\nDistance: " + Math.Round(distance,2));
        Console.WriteLine("Slope: " + Math.Round(line[0],2));
        Console.WriteLine("Y-Intercept: " + Math.Round(line[1],2));
        Console.WriteLine("Equation: y= " + Math.Round(line[0],2) + " x + " + Math.Round(line[1],2));

    }

    static double dist(double x1,double y1,double x2,double y2)
    {
        int a=Math.Pow(x2-x1,2);
        int b=Math.Pow(y2-y1,2);
        return Math.Sqrt(a+b);
    }

    static double[] linefunc(double x1,double y1,double x2,double y2)
    {
        double m=(y2-y1)/(x2-x1);
        double b=y1-(m*x1);
        return new double[]{m,b};
    }
}
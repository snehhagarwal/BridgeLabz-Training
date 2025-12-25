using System;
using System.Text.Json.Serialization.Metadata;

class Trignometric
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the angle in degree: ");
        double angle=Convert.ToDouble(Console.ReadLine());

        //function call
        double[] arr=Calculate(angle);

        Console.WriteLine("Sin: " + arr[0] + " ,Cos: " + arr[1] + " ,Tan: " + arr[2]);

    }

    public static double[] Calculate(double angle)
    {

        double rad=angle*Math.PI/180; //degree to radian
        //all the angles
        double sin=Math.Sin(rad);
        double cos=Math.Cos(rad);
        double tan=Math.Tan(rad);

        return new double[]{sin,cos,tan};
    }
}
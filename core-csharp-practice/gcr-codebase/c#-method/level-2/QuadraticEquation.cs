using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a,b,c: ");
        double a=Convert.ToDouble(Console.ReadLine());
        double b=Convert.ToDouble(Console.ReadLine());
        double c=Convert.ToDouble(Console.ReadLine());

        //function call
        double[] arr=root(a,b,c);

        //printing the result
        for(int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Root: " + arr[i]);
        }
    }

    static double[] root(double a,double b,double c)
    {
        //calculations
        double delta=Math.Pow(b,2)-4*a*c;
        if (delta < 0)
        {
            return new double[a];
        }
        int p=-b/(2*a);
        if (delta == 0)
        {
            return new double[]{p};
        }

        double sqrt=Math.Sqrt(delta);
        int q=(-b+sqrt)/(2*a);
        int r=(-b-sqrt)/(2*a);
        return new double[]{q,r};
    }
}
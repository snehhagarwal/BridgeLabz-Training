using System;

class SquareRoot{
    public static void Main(string[] args){

        Console.Write("Enter the number: ");
        int n=int.Parse(Console.ReadLine());
        Console.WriteLine("The square root of the number is: ");
        double result=Math.Sqrt(n);
        Console.Write(result);

    }
}
using System;

class ChocolateDistribution
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the chocolate: ");
        int chocolate=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the Childer: ");
        int children=Convert.ToInt32(Console.ReadLine());

        //function call
        int[] arr=func(chocolate,children);

        Console.WriteLine("Each Child gets: " + arr[0] + " Remaining " + arr[1]);

    }

    public static int[] func(int chocolate,int children)
    {
        //calculation 
        int a=chocolate/children;
        int b=chocolate%children;

        return new int[]{a,b};
    }
}
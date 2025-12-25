using System;
using System.Security.Cryptography.X509Certificates;

class SmallestLargest
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the three number: ");
        int a=Convert.ToInt32(Console.ReadLine());
        int b=Convert.ToInt32(Console.ReadLine());
        int c=Convert.ToInt32(Console.ReadLine());

        //function call
        int[] arr=Find(a,b,c);

        Console.WriteLine("Smallest: " + arr[0] + " Largest: " + arr[1]);
    }

    public static int[] Find(int a,int b,int c)
    {
        //finding the numbers
        int smallest=Math.Min(a,Math.Min(b,c));
        int largest=Math.Max(a,Math.Max(b,c));
        return new int[]{smallest,largest};
    }
}
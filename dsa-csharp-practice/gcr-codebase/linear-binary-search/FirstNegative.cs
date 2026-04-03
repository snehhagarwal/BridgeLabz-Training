using System;

class FirstNegative
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[n];

        Console.WriteLine("Enter elements: ");
        for(int i = 0; i < n; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        for(int i = 0; i < n; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("First Negative Number: " + arr[i]);
                return;
            }
        }

        Console.WriteLine("No negative number found");
    }
}
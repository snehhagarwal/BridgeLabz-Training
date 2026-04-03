using System;

class PositiveNegative
{
    static void Main(string[] args)
    {
        int[] arr=new int[5];

        //take input from the user
        for(int i = 0; i < 5; i++)
        {
            Console.Write("Enter the number: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());

            if (isPositive(arr[i]))
            {
                if (isEven(arr[i]))
                {
                    Console.WriteLine("Positive Even");
                }
                else
                {
                    Console.WriteLine("Positive Odd");
                }
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }

        int ans=compare(arr[0],arr[4]);
        if (ans == 0)
        {
            Console.WriteLine("Equal");
        }
        else if (ans > 0)
        {
            Console.WriteLine("First Greater");
        }
        else
        {
            Console.WriteLine("First Smaller");
        }
    }

    static bool isPositive(int n)
    {
        return n>=0;
    }

    static bool isEven(int n)
    {
        return n%2==0;
    }

    static int compare(int a,int b)
    {
        if (a > b)
        {
            return 1;
        }
        if (a == b)
        {
            return 0;
        }
        return -1;
    }
}
using System;

class NumberChecker5
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        int[] factor=Find(num);

        Console.WriteLine("Factors: ");
        for(int i = 0; i < factor.Length; i++)
        {
            Console.Write(factor[i] + " ");
        }

        Console.WriteLine("Greatest Factor: " + GreatestFactor(factor));
        Console.WriteLine("Sum of Factors: " + Sum(factor));
        Console.WriteLine("Product of Factors: " + Product(factor));
        Console.WriteLine("Product of cube of Factors: " + Cube(factor));

    }

    public static int[] Find(int number)
    {
        int cnt=0;

        for(int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                cnt++;
            }
        }

        int[] arr=new int[cnt];
        int idx=0;

        for(int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                arr[idx]=i;
                idx++;
            }
        }
        return arr;
    }

    public static int GreatestFactor(int[] arr)
    {
        int max=arr[0];
        for(int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max=arr[i];
            }
        }
        return max;
    }

    public static long Product(int[] arr)
    {
        long prod=1;
        for(int i = 0; i < arr.Length; i++)
        {
            prod*=arr[i];
        }
        return prod;
    }

    public static double Cube(int[] arr)
    {
        double prod=1;
        for(int i = 0; i < arr.Length; i++)
        {
            prod*=Math.Pow(arr[i],3);
        }
        return prod;
    }
}
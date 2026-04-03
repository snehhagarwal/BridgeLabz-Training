using System;

class Factors
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int n=Convert.ToInt32(Console.ReadLine());

        //function call
        int[] arr=func(n);

        //printing the factors
        Console.WriteLine("Factors: ");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nSum: " + Sum(arr));
        Console.WriteLine("Product: " + Product(arr));
        Console.WriteLine("Sum of Squares: " + SumOfSquare(arr));
    }

    //function for factors
    static int[] func(int n)
    {
        int cnt=0;
        for(int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                cnt++;
            }
        }
        int[] factor=new int[cnt];
        int idx=0;

        for(int i = 1; idx <= n; idx++)
        {
            if (n % i == 0)
            {
                factor[idx]=i;
                idx++;
            }
        }
        return factor;
    }

    //function for sum of factors
    static int Sum(int[] arr)
    {
        int sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=arr[i];
        }
        return sum;
    }

    //function for product of factors
    static int Product(int[] arr)
    {
        int ans=1;
        for(int i = 0; i < arr.Length; i++)
        {
            ans=ans*arr[i];
        }
        return ans;
    }

    //function for sum of square of factors
    static double SumOfSquare(int[] arr)
    {
        double sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=Math.Pow(arr[i],2);
        }
        return sum;
    }
}
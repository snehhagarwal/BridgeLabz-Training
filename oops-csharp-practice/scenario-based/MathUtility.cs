using System;

class MathUtility
{
    static void Main(string[] args)
    {
        //taking input from users
        Console.Write("Enter a number for Factorial: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //edge case for negative number
        if (num < 0)
        {
            Console.WriteLine("No negative number is allowed");
        }
        else
        {
            Console.WriteLine("Factorial: " + Factorial(num));
        }

        //input for prime number
        Console.Write("\nEnter a number to check prime: ");
        int num2=Convert.ToInt32(Console.ReadLine());

        if (IsPrime(num2))
        {
            Console.WriteLine("It is a Prime Number.");
        }
        else
        {
            Console.WriteLine("It is not a Prime Number");
        }

        //inputs for GCD calculation
        Console.Write("\nEnter first number for GCD: ");
        int num3=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number for GCD: ");
        int num4=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("GCD of two numbers is: " + GCD(num3,num4));

        //input for fibonacci series
        Console.Write("\nEnter n for fibonacci: ");
        int num5=Convert.ToInt32(Console.ReadLine());

        //edge case for negative number
        if (num5 < 0)
        {
            Console.WriteLine("For negative number no series can be generated");
        }
        else
        {
            Console.WriteLine("Fibonacci number: " + Fibonacci(num5));
        }
    }

    //function for calculating factorial
    public static long Factorial(int n)
    {
        long ans=1;
        for(int i = 1; i <= n; i++)
        {
            ans*=i;
        }
        return ans;
    }

    //function for prime check
    public static bool IsPrime(int n)
    {
        if (n <= 1)
        {
            return false;
        }
        for(int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    //function for GCD
    public static int GCD(int a,int b)
    {
        a=Math.Abs(a);
        b=Math.Abs(b);

        while (b != 0)
        {
            int temp=b;
            b=a%b;
            a=temp;
        }
        return a;
    }

    //function for fibonacci
    public static int Fibonacci(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }
        int a=0;  //first fibonacci number
        int b=1;  //second fibonacci number

        for(int i = 2; i <= n; i++)
        {
            int temp=a+b;
            a=b;
            b=temp;
        }
        return b;
    }
}
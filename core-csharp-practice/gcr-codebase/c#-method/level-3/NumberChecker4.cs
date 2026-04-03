using System;

class NumberChecker4
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Prime Number: " + Prime(num));
        Console.WriteLine("Neon Number: " + Neon(num));
        Console.WriteLine("Spy Number: " + Spy(num));
        Console.WriteLine("Automorphic Number: " + Automorphic(num));
        Console.WriteLine("Buzz Number: " + Buzz(num));
    }

    public static bool Prime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        for(int i = 2; i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    public static bool Neon(int num)
    {
        int square=num*num;
        int sum=0;

        while (square > 0)
        {
            sum+=square%10;
            square/=10;
        }
        return sum==num;
    }

    public static bool Spy(int num)
    {
        int sum=0;
        int prod=1;
        int temp=num;

        while (temp > 0)
        {
            int digit=temp%10;
            sum+=digit;
            prod*=digit;
            temp/=10;
        }
        return sum==prod;
    }

    public static bool Automorphic(int num)
    {
        int square=num*num;
        int temp=num;

        while (temp > 0)
        {
            if(temp%10 != square % 10)
            {
                return false;
            }
            temp/=10;
            square/=10;
        }
        return true;
    }

    public static bool Buzz(int num)
    {
        if(num%7==0 || num % 10 == 7)
        {
            return true;
        }
        return false;
    }
}
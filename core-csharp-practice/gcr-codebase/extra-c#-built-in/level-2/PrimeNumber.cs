using System;

class PrimeNumber
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        if (isPrime(num))
        {
            Console.WriteLine("Prime Number");
        }
        else
        {
            Console.WriteLine("Not a Prime Number");
        }
    }

    static bool isPrime(int num)
    {
        //edge case
        if (num <= 1)
        {
            return false;
        }

        //if factor more than 1
        for(int i = 2; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}
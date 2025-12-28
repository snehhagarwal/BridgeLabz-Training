using System;

class FactorialRecursion
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Factorial: " + Factorial(num));
    }

    static int Factorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n*Factorial(n-1);
    }
}
using System;

class Sum
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter n: ");
        int n=Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            return;
        }

        //sum using recursion and formula
        int r1=Recursive(n);
        int r2=formula(n);

        //printing statement 
        Console.WriteLine("Recursive sum: " + r1);
        Console.WriteLine("Formula Sum: " + r2);

        //comparing result
        if (r1 == r2)
        {
            Console.WriteLine("Results are same.");
        }
        else
        {
            Console.WriteLine("Results differ");
        }
    }

    static int Recursive(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        return n + Recursive(n-1);
    }

    static int formula(int n)
    {
        return n*(n+1)/2;
    }
}
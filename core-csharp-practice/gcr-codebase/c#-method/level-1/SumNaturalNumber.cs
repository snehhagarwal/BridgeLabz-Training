using System;

class SumNaturalNumber
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter n: ");
        int n=Convert.ToInt32(Console.ReadLine());

        //function call
        int sum=Sum(n);

        //printing statement
        Console.WriteLine("Sum: " + sum);
    }

    static int Sum(int n)
    {
        int total=0;
        for(int i = 1; i <= n; i++)
        {
            total+=i;
        }
        return total;
    }
}
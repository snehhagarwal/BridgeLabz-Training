using System;

class PositiveNegativeZero
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int n=Convert.ToInt32(Console.ReadLine());

        //function call
        int ans=Check(n);

        //printing statement 
        Console.WriteLine("Result: " + ans);
    }

    static int Check(int n)
    {
        //calculations
        if (n > 0)
        {
            return 1;
        }
        if (n < 0)
        {
            return -1;
        }
        return 0;
    }
}
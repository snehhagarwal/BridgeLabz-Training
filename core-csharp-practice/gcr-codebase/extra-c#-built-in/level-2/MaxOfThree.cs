using System;

class MaxOfThree
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the first number: ");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int c=Convert.ToInt32(Console.ReadLine());

        //function call
        int max=GetMax(a,b,c);

        Console.WriteLine("Maximum of Three Numbers is: " + max);
    }

    static int GetMax(int a,int b,int c)
    {
        //maximum number
        int max=a;
        if (b > max)
        {
            max=b;
        }
        if (c > max)
        {
            max=c;
        }
        return max;
    }
}
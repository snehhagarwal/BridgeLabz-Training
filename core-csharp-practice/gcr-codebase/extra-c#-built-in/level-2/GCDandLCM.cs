using System;

class GCDandLCM{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the first number: ");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b=Convert.ToInt32(Console.ReadLine());
 
        Console.WriteLine("GCD is: " + GCD(a,b));
        Console.WriteLine("LCM is: " + LCM(a,b));

    }

    static int GCD(int a,int b)
    {
        while (b != 0)
        {
            int temp=b;
            b=a%b;
            a=temp;
        }
        return a;
    }

    static int LCM(int a,int b)
    {
        return (a*b)/GCD(a,b);
    }
}
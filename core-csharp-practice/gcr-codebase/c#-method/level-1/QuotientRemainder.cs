using System;

class QuotientRemainder
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int div=Convert.ToInt32(Console.ReadLine());

        //function call
        int[] arr= QuoRem(number,div);

        Console.WriteLine("Quotient: " + arr[0] + " Remainder: " + arr[1]);
    }

    public static int[] QuoRem(int number,int div)
    {
        //calculation of quotient and remainder
        int a=number/div;
        int b=number%div;
        return new int[] {a,b};
    }
}
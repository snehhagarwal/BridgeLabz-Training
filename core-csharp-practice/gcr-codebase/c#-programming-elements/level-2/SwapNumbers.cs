using System;

class SwapNumbers{
    static void Main(string[] args){
        //taking input from user
        Console.WriteLine("Enter the 1st number: ");
        int a=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the 2nd number: ");
        int b=Convert.ToInt32(Console.ReadLine());

        //using a third variable
        int temp=a;
        a=b;
        b=temp;

        Console.WriteLine("The swapped numbers are " + a + " and " + b);


    }
}
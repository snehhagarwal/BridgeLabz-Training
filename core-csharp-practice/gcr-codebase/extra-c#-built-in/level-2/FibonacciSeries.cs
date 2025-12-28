using System;

class FibonacciSeries
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        PrintFibo(num);
    }

    static void PrintFibo(int num)
    {
        int a=0;  //1st fibonacci number
        int b=1;  //2nd fibonacci number

        for(int i = 1; i <= num; i++)
        {
            Console.Write(a+" ");
            int next=a+b;
            a=b;
            b=next;
        }
    }
}
using System;

class DateComparison
{
    static void Main(string[] args)
    {
        //take input from user
        Console.Write("Enter first date (yyyy-MM-dd): ");
        DateTime d1=DateTime.Parse(Console.ReadLine());

        Console.Write("Enter second date (yyyy-MM-dd): ");
        DateTime d2=DateTime.Parse(Console.ReadLine());

        //compared the two dates
        int ans=DateTime.Compare(d1,d2);

        //printing statement 
        if (ans < 0)
        {
            Console.WriteLine("First date is Before second date");
        }else if (ans > 0)
        {
            Console.WriteLine("First date is After second date");
        }
        else
        {
            Console.WriteLine("Both dates are the Same");
        }
    }
}
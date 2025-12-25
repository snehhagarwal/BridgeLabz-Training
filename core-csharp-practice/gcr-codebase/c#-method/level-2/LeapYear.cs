using System;

class LeapYear
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());

        bool ans=func(year);

        if (ans)
        {
            Console.WriteLine("Leap Year");
        }
        else
        {
            Console.WriteLine("Not a Leap Year");           
        }
    }

    static bool func(int year)
    {
        if (year < 1582)
        {
            return false;
        }
        bool result=(year%4==0 && year%100!=0) || year%400==0;
        return result;
    }
}
using System;

class DateArithmetic
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a date (yyy-MM-dd): ");
        DateTime date=DateTime.Parse(Console.ReadLine());

        DateTime ans=date.AddDays(7).AddMonths(1).AddYears(2).AddDays(-21); 

        //printing statement
        Console.WriteLine("Final Date: " + ans.ToShortDateString());
    }
}
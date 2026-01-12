using System;
using System.Collections.Generic;

public class RevenueReport
{
    public void Print(string title,int revenue)
    {
        Console.WriteLine(title);
        Console.WriteLine("Revenue: " + revenue);
    }
}
using System;

public class Chef : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Chef is preparing meals");
    }
}
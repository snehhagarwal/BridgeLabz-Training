using System;

public class Waiter : Person, Worker
{
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving food");
    }
}
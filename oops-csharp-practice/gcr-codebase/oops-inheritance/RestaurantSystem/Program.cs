using System;

class Program
{
    static void Main(string[] args)
    {
        Chef c = new Chef();
        c.Name = "Rahul";
        c.Id = 1;
        c.PerformDuties();

        Waiter w = new Waiter();
        w.Name = "Amit";
        w.Id = 2;
        w.PerformDuties();
    }
}
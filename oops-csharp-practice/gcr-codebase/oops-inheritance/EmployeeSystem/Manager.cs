using System;

class Manager : Employee
{
    public int size;
    public override void Display()
    {
        Console.WriteLine("Manager Details");
        Console.WriteLine("Manager Name: " + Name);
        Console.WriteLine("Team Size: " + size);
    }
}
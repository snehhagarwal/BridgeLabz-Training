using System;

class Intern: Employee
{
    public string Duration;
    public override void Display()
    {
        Console.WriteLine("Intern Details: ");
        Console.WriteLine("Intern Name: " + Name);
        Console.WriteLine("Intern Duration: " + Duration);
    }
}
using System;

public class Staff : Person
{
    public string Dept;

    public void Display()
    {
        Console.WriteLine("Role: Staff");
        Console.WriteLine("Department: " + Dept);
    }
}
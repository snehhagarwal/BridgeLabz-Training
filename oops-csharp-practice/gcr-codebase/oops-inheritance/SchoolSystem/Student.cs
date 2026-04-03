using System;

public class Student : Person
{
    public string Grade;

    public void Display()
    {
        Console.WriteLine("Role: Student");
        Console.WriteLine("Grade: " + Grade);
    }
}
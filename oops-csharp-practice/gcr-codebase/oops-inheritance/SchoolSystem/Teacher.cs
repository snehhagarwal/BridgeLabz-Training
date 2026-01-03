using System;

public class Teacher : Person
{
    public string Subject;

    public void Display()
    {
        Console.WriteLine("Role: Teacher");
        Console.WriteLine("Subject: " + Subject);
    }
}
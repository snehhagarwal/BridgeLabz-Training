using System;

class Developer : Employee
{
    public string Language;
    public override void Display()
    {
        Console.WriteLine("Developer Details: ");
        Console.WriteLine("Developer Name: " + Name);
        Console.WriteLine("Programming Language: " + Language) ;
    }
}
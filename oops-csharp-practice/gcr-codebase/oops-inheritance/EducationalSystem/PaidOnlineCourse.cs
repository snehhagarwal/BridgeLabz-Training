using System;

class PaidOnlineCourse : OnlineCourse
{
    public double Fee;
    public double Discount;

    public void Display()
    {
        Console.WriteLine("Course Name: " + CourseName);
        Console.WriteLine("Duration: " + Duration);
        Console.WriteLine("Platform: " + Platform);
        Console.WriteLine("Recorded: " + isrecords);
        Console.WriteLine("Fee: " + Fee);
        Console.WriteLine("Discount: " + Discount);
    }
}
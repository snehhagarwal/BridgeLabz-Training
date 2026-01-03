using System;

class Program
{
    static void Main(string[] args)
    {
        PaidOnlineCourse a=new PaidOnlineCourse();
        a.CourseName=".Net and C#";
        a.Duration=60;
        a.Platform="Udemy";
        a.isrecords=true;
        a.Fee=6000;
        a.Discount=10;

        a.Display();
    }
}
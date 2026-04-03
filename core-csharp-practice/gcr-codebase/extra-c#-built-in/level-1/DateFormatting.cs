using System;

class DateFormatting
{
    static void Main(string[] args)
    {
        //taking current date and time
        DateTime today=DateTime.Now;

        //printing statement in diff format
        Console.WriteLine("Format dd/MM/yyyy: " + today.ToString("dd/MM/yyyy"));
        Console.WriteLine("Format yyyy-MM-dd: " + today.ToString("yyyy-MM-dd"));
        Console.WriteLine("Format EEE, MMM dd, yyyy: " + today.ToString("ddd, MMM dd, yyyy"));
        
    }
}
using System;

class TimeZone
{
    static void Main(string[] args)
    {
        //getting the time
        DateTimeOffset utcTime=DateTimeOffset.UtcNow;

        //time in three different time zones
        TimeZoneInfo gmt=TimeZoneInfo.Utc;
        TimeZoneInfo ist=TimeZoneInfo.FindSystemTimeZoneById("Indian Standard Time: ");
        TimeZoneInfo pst=TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time: ");

        //printing statement
        Console.WriteLine("GMT Time: " + TimeZoneInfo.ConvertTime(utcTime,gmt));
        Console.WriteLine("IST Time: " + TimeZoneInfo.ConvertTime(utcTime,ist));
        Console.WriteLine("PST Time: "+ TimeZoneInfo.ConvertTime(utcTime,pst));

    }
}
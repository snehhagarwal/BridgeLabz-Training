using System;

class Calendar
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter Month: ");
        int month=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Year: ");
        int year=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine(GetMonth(month)+" " + year);
        Console.WriteLine("Sun Mon Tue Wed Thu Fri Sat");

        int first=GetFirst(month,year);
        int day=GetDay(month,year);

        // d & e) First loop for indentation
        for(int i = 0; i < first; i++)
        {
            Console.Write("   ");
        }

        // f) Second loop to print days
        for(int i = 1; i <= day; i++)
        {
            Console.Write(String.Format("{0,3}",day));

            if ((i + first) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
    }

    // a) Method to get month name
    static string GetMonth(int month)
    {
        string[] months={"January","February","March","April","May","June",
            "July","August","September","October","November","December"};
        
        return months[month-1];
    }

    // Leap year method
    static bool Leap(int year)
    {
        if (year % 400 == 0)
        {
            return true;
        }
        if (year % 100 == 0)
        {
            return false;
        }
        if (year % 4 == 0)
        {
            return true;
        }
        return false;
    }

    // b) Method to get number of days in month
    static int GetDay(int month,int year)
    {
        int[] days={ 31,28,31,30,31,30,31,31,30,31,30,31};
        if(month==2 && Leap(year))
        {
            return 29;
        }
        return days[month-1];
    }

    // c) Method to get first day of month (Gregorian algorithm)
    static int GetFirst(int month,int year)
    {
        int d=1;
        int y0=year-(14-month)/12;
        int x=y0+y0/4-y0/100+y0/400;
        int m0=month+12*((14-month)/12)-2;
        int d0=(d+x+(31*m0)/12)%7;
        return d0; //0=sunday
    }
}
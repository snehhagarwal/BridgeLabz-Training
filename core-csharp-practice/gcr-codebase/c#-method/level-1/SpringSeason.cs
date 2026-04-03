using System;

class SpringSeason
{
    static void Main(string[] args)
    {
        //taking input from the command line 
        int month=Convert.ToInt32(args[0]);
        int day=Convert.ToInt32(args[1]);

        bool flag=Spring(month,day);

        if (flag)
        {
            Console.WriteLine("Its a Spring Season");
        }
        else
        {
            Console.WriteLine("Not a Spring Season");
        }
    }

    static bool Spring(int month,int day)
    {
        if((month==3 && day>=20) || (month>3 && month<6) || (month==6 && day <= 20))
        {
            return true;
        }
        return false;
    }
}
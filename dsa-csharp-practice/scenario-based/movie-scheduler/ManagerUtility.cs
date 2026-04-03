using System;
using System.Collections.Generic;
System.Text.RegularExpressions;

class ManagerUtility : IMovieOperations
{
    int length=Convert.ToInt32(Console.ReadLine());
    private Movie[] movies=new Movie[length];
    private int cnt=0;

    public void Add(string title,string time)
    {
        if (cnt>=movies.Length)
        {
            Console.WriteLine("Movie list is full");
            return;
        }
        if (ValidTime(time))
        {
            movies[cnt]=new Movie(title,time);
            cnt++;
        }
        else
        {
            Console.WriteLine("Movie has invalid time format");
        }
    }

    public void Search(string keyword)
    {
        bool found=false;
        for(int i = 0; i < movies.Count; i++)
        {
            if (movies[i].Title.Contains(keyword,StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(movies[i].Title + " at " + movies[i].ShowTime);
                found=true;
            }
        }

        if (!found)
        {
            Console.WriteLine("No Movie found");
        }
    }

    public void DisplayAll()
    {
        for(int i = 0; i < cnt; i++)
        {
            Console.WriteLine((i+1) + ". " + movies[i].Title + " - " + movies[i].ShowTime);
        }
    }

    public void GenerateReport()
    {
        Console.WriteLine("Movie Report");
        for(int i = 0; i < cnt; i++)
        {
            Console.WriteLine(movies[i].Title + " | " + movies[i].ShowTime);
        }
    }

    //HH:MM
    private bool ValidTime(string time)
    {
        if (time.Length != 5)
        {
            return false;
        }
        if (time[2] != ':')
        {
            return false;
        }

        int hour=(time[0]-'0') *10 + (time[1]-'0');
        int min=(time[3]-'0')*10 + (time[4]-'0');

        if(hour<0 || hour > 23)
        {
            return false;
        }
        if(min<0 || min > 59)
        {
            return false;
        }
        return true;
    }
}
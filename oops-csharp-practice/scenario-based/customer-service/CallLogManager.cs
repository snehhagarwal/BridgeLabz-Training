using System;

// Manages call logs
public class CallLogManager
{
    CallLog[] arr=new CallLog[50];   // Array to store logs
    int cnt=0;                       // Log count

    // Add new call log
    public void AddCallLog()
    {
         // Check capacity
        if (cnt >= arr.Length)
        {
            Console.WriteLine("Log storage full");
            return;
        }

        //take input from the user
        Console.Write("Enter Phone Number: ");
        string phone=Console.ReadLine();

        Console.Write("Enter message: ");
        string msg=Console.ReadLine();

        DateTime time=DateTime.Now;

        arr[cnt]=new CallLog(phone,msg,time);   // Store log
        cnt++;

        Console.WriteLine("Call log added successfully");
    }

    // Search using keyword
    public void SearchByKeyword()
    {
        Console.Write("Enter keyword to search: ");
        string key=Console.ReadLine();

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i].GetMsg().Contains(key))   // Match keyword
            {      
                arr[i].Display();                // Show log
            }
        }
    }

    // Filter by time range
    public void FilterByTime()   
    {
        Console.Write("Enter start time: ");
        DateTime start=Convert.ToDateTime(Console.ReadLine());

        Console.Write("Enter end time: ");
        DateTime end=Convert.ToDateTime(Console.ReadLine());

        for(int i = 0; i < cnt; i++)
        {
            DateTime logTime=arr[i].GetTime();

            if(logTime>=start && logTime <= end)      // Check range
            {
                arr[i].Display();                     // Show log
            }
        }
    }
}
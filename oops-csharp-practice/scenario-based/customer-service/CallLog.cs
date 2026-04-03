using System;

// Class to store call log details
public class CallLog
{
    protected string phoneNumber;    // Store phone number
    protected string message;        // Store message
    protected DateTime timestamp;    // Store call time

    public CallLog(string pno,string msg,DateTime time)
    {
        phoneNumber=pno;             // Set phone number
        message=msg;                 // Set message
        timestamp=time;              // Set time
    }

    // Return message
    public string GetMsg()   
    {
        return message;
    }

    // Return timestamp
    public DateTime GetTime()
    {
        return timestamp;
    }

    // Display call log details
    public void Display()
    {
        Console.WriteLine("Phone Number: " + phoneNumber);
        Console.WriteLine("Message: " + message);
        Console.WriteLine("Time: " + timestamp);
    }
}

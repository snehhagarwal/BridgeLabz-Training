using System;

class Hotel
{
    public string GuestName;
    public string RoomType;
    public int Nights;

    public Hotel()
    {
        
    }

    public Hotel(string guest,string room,int night)
    {
        this.GuestName=guest;
        this.RoomType=room;
        this.Nights=night;
    }

    public Hotel(Hotel h)
    {
        GuestName=h.GuestName;
        RoomType=h.RoomType;
        Nights=h.Nights;
    }

    public void Display()
    {
        Console.WriteLine("Guest Name is " + GuestName + " .The Room type is " + RoomType + " .It is booked for " + Nights + " nights.");
    }
}

class HotelBooking
{
    static void Main(string[] args)
    {
        Console.Write("Enter guest name: ");
        string name=Console.ReadLine();

        Console.Write("Enter Room Type: ");
        string room=Console.ReadLine();

        Console.Write("Enter the number of Nights: ");
        int night=Convert.ToInt32(Console.ReadLine());

        Hotel h=new Hotel();
        h.Display();
    }
}
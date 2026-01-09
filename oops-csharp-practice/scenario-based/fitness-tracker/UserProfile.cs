using System;

class UserProfile
{
    private string userName; //user name

    //constructor
    public UserProfile(string name)
    {
        userName=name;
    }

    //displaying user name
    public void ShowUser()
    {
        Console.WriteLine("User Name: " + userName);
    }
}
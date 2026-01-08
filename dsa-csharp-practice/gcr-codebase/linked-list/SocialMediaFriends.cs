using System;

class UserNode
{
    public int Id;
    public string Name;
    public int Friends;
    public UserNode next;
}

class SocialMain
{
    static void Main()
    {
        UserNode u1 = new UserNode { Id = 1, Name = "Sneha", Friends = 5 };
        UserNode u2 = new UserNode { Id = 2, Name = "Aman", Friends = 3 };
        u1.next = u2;

        UserNode temp = u1;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} Friends:{temp.Friends}");
            temp = temp.next;
        }
    }
}

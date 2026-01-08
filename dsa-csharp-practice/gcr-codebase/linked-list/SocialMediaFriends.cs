using System;

// Class representing a user node in the linked list
class UserNode
{
    // Unique identifier for the user
    public int Id;
    // Name of the user
    public string Name;
    // Number of friends
    public int Friends;
    // Reference to the next node
    public UserNode next;
}

// Main class for the social media friends demonstration
class SocialMain
{
    // Main entry point
    static void Main()
    {
        // Create first user
        UserNode u1 = new UserNode { Id = 1, Name = "Sneha", Friends = 5 };
        // Create second user
        UserNode u2 = new UserNode { Id = 2, Name = "Aman", Friends = 3 };
        // Link the first to the second
        u1.next = u2;
        // Start traversal from the first node
        UserNode temp = u1;
        // Traverse the list and print each user's name and friends count
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} Friends:{temp.Friends}");
            temp = temp.next;
        }
    }
}

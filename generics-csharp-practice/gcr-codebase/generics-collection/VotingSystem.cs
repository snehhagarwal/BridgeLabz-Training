using System;
using System.Collections.Generic;

class VotingSystem
{
    public static void Main()
    {
        Dictionary<string, int> votes = new Dictionary<string, int>(); // Store votes

        // Cast votes
        Vote(votes, "Alice"); 
        Vote(votes, "Bob");
        Vote(votes, "Alice");

        // Display original votes
        Console.WriteLine("Votes:");
        foreach (KeyValuePair<string, int> v in votes)
            Console.WriteLine(v.Key + " : " + v.Value);

        // Sort votes by candidate name
        SortedDictionary<string, int> sorted =
            new SortedDictionary<string, int>(votes);

        // Display sorted votes
        Console.WriteLine("\nSorted Votes:");
        foreach (KeyValuePair<string, int> v in sorted)
            Console.WriteLine(v.Key + " : " + v.Value);
    }

    // Function to cast a vote
    static void Vote(Dictionary<string, int> votes, string name)
    {
        if (votes.ContainsKey(name))
            votes[name]++; // Increment existing vote
        else
            votes[name] = 1; // Add new candidate with 1 vote
    }
}

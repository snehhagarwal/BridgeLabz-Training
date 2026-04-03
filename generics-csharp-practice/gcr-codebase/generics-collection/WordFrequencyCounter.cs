using System;
using System.Collections.Generic;
using System.IO;

class WordFrequencyCounter
{
    public static void Main()
    {
        Dictionary<string, int> wordCount = new Dictionary<string, int>(); // Store word frequencies

        Console.Write("Enter file path: ");
        string path = Console.ReadLine(); // Read file path

        if (!File.Exists(path)) // Check if file exists
        {
            Console.WriteLine("File not found.");
            return;
        }

        string text = File.ReadAllText(path); // Read entire file content

        // Define separators and split words
        char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\r', '\t' };
        string[] words = text.ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        // Count word frequencies
        foreach (string word in words)
        {
            if (wordCount.ContainsKey(word))
                wordCount[word]++; // Increment existing word count
            else
                wordCount[word] = 1; // Add new word with count 1
        }

        // Display word frequencies
        Console.WriteLine("\nWord Frequencies:");
        foreach (var pair in wordCount)
        {
            Console.WriteLine($"{pair.Key} : {pair.Value}");
        }
    }
}

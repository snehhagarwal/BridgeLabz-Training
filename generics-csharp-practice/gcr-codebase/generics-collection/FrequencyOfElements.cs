using System;
using System.Collections.Generic;

class FrequencyOfElements
{
    public static void Main()
    {
        // Store elements
        List<string> list = new List<string>();

        // Store frequency
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        // Input size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            string item = Console.ReadLine();
            list.Add(item); // Add to list
        }

        // Count frequency
        foreach (string item in list)
        {
            if (frequency.ContainsKey(item))
                frequency[item]++;    // Increment count
            else
                frequency[item] = 1;  // First occurrence
        }

        // Display result
        Console.WriteLine("Element Frequencies:");
        foreach (var pair in frequency)
        {
            Console.WriteLine(pair.Key + " : " + pair.Value);
        }
    }
}

using System;
using System.Collections.Generic;

class InvertAMap
{
    public static void Main()
    {
        // Original key-value map
        Dictionary<string, int> originalMap = new Dictionary<string, int>();

        // Inverted value-key map
        Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();

        // Input size
        Console.Write("Enter number of entries: ");
        int n = int.Parse(Console.ReadLine());

        // Read map entries
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter key: ");
            string key = Console.ReadLine();

            Console.Write("Enter value: ");
            int value = int.Parse(Console.ReadLine());

            originalMap[key] = value; // Add entry
        }

        // Invert the map
        foreach (var pair in originalMap)
        {
            if (!invertedMap.ContainsKey(pair.Value))
                invertedMap[pair.Value] = new List<string>();

            invertedMap[pair.Value].Add(pair.Key); // Add key
        }

        // Display inverted map
        Console.WriteLine("\nInverted Map:");
        foreach (var pair in invertedMap)
        {
            Console.Write(pair.Key + " = [ ");
            foreach (string key in pair.Value)
            {
                Console.Write(key + " ");
            }
            Console.WriteLine("]");
        }
    }
}

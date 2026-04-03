using System;
using System.Collections.Generic;

class RemoveDuplicatesByPreservingOrder
{
    public static void Main()
    {
        // Original list
        List<int> list = new List<int>();

        // Result list
        List<int> result = new List<int>();

        // Track seen elements
        HashSet<int> seen = new HashSet<int>();

        // Input size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine())); // Add to list
        }

        // Remove duplicates
        foreach (int item in list)
        {
            if (!seen.Contains(item))
            {
                seen.Add(item);    // Mark seen
                result.Add(item);  // Preserve order
            }
        }

        // Display result
        Console.WriteLine("List after removing duplicates:");
        foreach (int item in result)
        {
            Console.Write(item + " ");
        }
    }
}

using System;
using System.Collections.Generic;

class SetToSortedList
{
    public static void Main()
    {
        // Create HashSet
        HashSet<int> set = new HashSet<int>();

        // Input size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            set.Add(int.Parse(Console.ReadLine())); // Add to set
        }

        // Convert to list
        List<int> sortedList = new List<int>(set);

        // Sort list
        sortedList.Sort();

        // Display result
        Console.WriteLine("Sorted List:");
        foreach (int item in sortedList)
        {
            Console.Write(item + " ");
        }
    }
}

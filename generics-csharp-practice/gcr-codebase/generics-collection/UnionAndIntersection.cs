using System;
using System.Collections.Generic;

class UnionAndIntersection
{
    public static void Main()
    {
        HashSet<int> set1 = new HashSet<int>(); // Create first set
        HashSet<int> set2 = new HashSet<int>(); // Create second set

        Console.Write("Enter number of elements in Set 1: ");
        int n1 = int.Parse(Console.ReadLine()); // Read size of set 1

        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            set1.Add(int.Parse(Console.ReadLine())); // Add elements to set 1
        }

        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine()); // Read size of set 2

        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            set2.Add(int.Parse(Console.ReadLine())); // Add elements to set 2
        }

        // Union of set1 and set2
        HashSet<int> unionSet = new HashSet<int>(set1); 
        unionSet.UnionWith(set2); // Combine both sets

        // Intersection of set1 and set2
        HashSet<int> intersectionSet = new HashSet<int>(set1); 
        intersectionSet.IntersectWith(set2); // Get common elements

        // Display union
        Console.WriteLine("Union:");
        foreach (int item in unionSet)
        {
            Console.Write(item + " "); // Print each element
        }

        // Display intersection
        Console.WriteLine("\nIntersection:");
        foreach (int item in intersectionSet)
        {
            Console.Write(item + " "); // Print each element
        }
    }
}

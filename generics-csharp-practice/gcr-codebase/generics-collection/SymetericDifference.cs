using System;
using System.Collections.Generic;

class SymetericDifference
{
    public static void Main()
    {
        // Create sets
        HashSet<int> set1 = new HashSet<int>();
        HashSet<int> set2 = new HashSet<int>();

        // Input Set 1 size
        Console.Write("Enter number of elements in Set 1: ");
        int n1 = int.Parse(Console.ReadLine());

        // Read Set 1 elements
        Console.WriteLine("Enter elements of Set 1:");
        for (int i = 0; i < n1; i++)
        {
            set1.Add(int.Parse(Console.ReadLine())); // Add element
        }

        // Input Set 2 size
        Console.Write("Enter number of elements in Set 2: ");
        int n2 = int.Parse(Console.ReadLine());

        // Read Set 2 elements
        Console.WriteLine("Enter elements of Set 2:");
        for (int i = 0; i < n2; i++)
        {
            set2.Add(int.Parse(Console.ReadLine())); // Add element
        }

        // Copy Set 1
        HashSet<int> symmetricDifference = new HashSet<int>(set1);

        // Remove common elements
        symmetricDifference.SymmetricExceptWith(set2);

        // Display result
        Console.WriteLine("Symmetric Difference:");
        foreach (int item in symmetricDifference)
        {
            Console.Write(item + " ");
        }
    }
}

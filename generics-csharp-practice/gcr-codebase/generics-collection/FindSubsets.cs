using System;
using System.Collections.Generic;

class FindSubsets
{
    public static void Main()
    {
        // Create sets
        HashSet<int> setA = new HashSet<int>();
        HashSet<int> setB = new HashSet<int>();

        // Input size of Set A
        Console.Write("Enter number of elements in Set A: ");
        int n1 = int.Parse(Console.ReadLine());

        // Read Set A elements
        Console.WriteLine("Enter elements of Set A:");
        for (int i = 0; i < n1; i++)
        {
            setA.Add(int.Parse(Console.ReadLine())); // Add element
        }

        // Input size of Set B
        Console.Write("Enter number of elements in Set B: ");
        int n2 = int.Parse(Console.ReadLine());

        // Read Set B elements
        Console.WriteLine("Enter elements of Set B:");
        for (int i = 0; i < n2; i++)
        {
            setB.Add(int.Parse(Console.ReadLine())); // Add element
        }

        // Subset check
        bool isSubset = setA.IsSubsetOf(setB);

        // Output result
        Console.WriteLine("Is Set A a subset of Set B?");
        Console.WriteLine(isSubset);
    }
}

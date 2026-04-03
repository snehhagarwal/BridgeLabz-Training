using System;
using System.Collections.Generic;

class RotateElements
{
    public static void Main()
    {
        // Store elements
        List<int> list = new List<int>();

        // Input size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            list.Add(int.Parse(Console.ReadLine())); // Add element
        }

        // Rotation count
        Console.Write("Enter rotation count: ");
        int k = int.Parse(Console.ReadLine());

        // Normalize rotation
        k = k % n;

        // Rotated list
        List<int> rotatedList = new List<int>();

        // Add elements from k to end
        for (int i = k; i < n; i++)
        {
            rotatedList.Add(list[i]);
        }

        // Add first k elements
        for (int i = 0; i < k; i++)
        {
            rotatedList.Add(list[i]);
        }

        // Output result
        Console.WriteLine("Rotated List:");
        foreach (int item in rotatedList)
        {
            Console.Write(item + " ");
        }
    }
}

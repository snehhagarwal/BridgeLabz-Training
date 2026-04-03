using System;
using System.Collections.Generic;

class GenerateBinaryNumberUsingQueue
{
    public static void Main()
    {
        // Queue for binary generation
        Queue<string> queue = new Queue<string>();

        // Store result
        List<string> result = new List<string>();

        // Input N
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        // Start with 1
        queue.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = queue.Dequeue();   // Remove front
            result.Add(current);                // Save number

            queue.Enqueue(current + "0");       // Append 0
            queue.Enqueue(current + "1");       // Append 1
        }

        // Output result
        Console.WriteLine("First " + n + " Binary Numbers:");
        foreach (string binary in result)
        {
            Console.Write(binary + " ");
        }
    }
}

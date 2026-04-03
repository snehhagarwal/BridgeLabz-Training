using System;
using System.Collections.Generic;

class ReverseAQueue
{
    // Recursive reverse method
    public static void Reverse(Queue<int> queue)
    {
        if (queue.Count == 0)
            return;                 // Base case

        int front = queue.Dequeue(); // Remove front
        Reverse(queue);              // Recursive call
        queue.Enqueue(front);        // Add back
    }

    public static void Main()
    {
        // Queue creation
        Queue<int> queue = new Queue<int>();

        // Input size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(int.Parse(Console.ReadLine())); // Enqueue
        }

        // Reverse queue
        Reverse(queue);

        // Display result
        Console.WriteLine("Reversed Queue:");
        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
    }
}

using System;
using System.Collections.Generic;

public class ReverseLinkedList
{
    public static void Main()
    {
        // LinkedList creation
        LinkedList<int> list = new LinkedList<int>();

        // Input size
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
        {
            int value = int.Parse(Console.ReadLine());
            list.AddLast(value); // Add to list
        }

        // Store reversed list
        LinkedList<int> reversedList = new LinkedList<int>();

        // Reverse using AddFirst
        foreach (int item in list)
        {
            reversedList.AddFirst(item);
        }

        // Output result
        Console.WriteLine("Reversed LinkedList:");
        foreach (int item in reversedList)
        {
            Console.Write(item + " ");
        }
    }
}

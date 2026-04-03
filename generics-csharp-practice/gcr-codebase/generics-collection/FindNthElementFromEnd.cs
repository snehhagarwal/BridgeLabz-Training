using System;
using System.Collections.Generic;

class FindNthElementFromEnd
{
    public static void Main()
    {
        // Linked list creation
        LinkedList<string> list = new LinkedList<string>();

        // Input count
        Console.Write("Enter number of elements:");
        int count = int.Parse(Console.ReadLine());

        // Read elements
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < count; i++)
        {
            list.AddLast(Console.ReadLine()); // Add to list
        }

        // Input N
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        // Two pointers
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        // Move first pointer N steps
        for (int i = 0; i < n; i++)
        {
            if (first == null)
            {
                Console.WriteLine("N is greater than the number of elements.");
                return;
            }
            first = first.Next;
        }

        // Move both pointers together
        while (first != null)
        {
            first = first.Next;
            second = second.Next;
        }

        // Output result
        Console.WriteLine("Nth element from the end:");
        Console.WriteLine(second.Value);
    }
}

using System;
using System.Collections.Generic;

// Implements a queue using two stacks
class QueueUsingStack
{
    // Stack for enqueue operations
    static Stack<int> s1=new Stack<int>();
    // Stack for dequeue operations
    static Stack<int> s2=new Stack<int>();

    // Adds an element to the queue
    static void Enqueue(int value)
    {
        s1.Push(value);
    }

    // Removes and returns the front element
    static int Dequeue()
    {
        if (s2.Count == 0)
        {
            // Transfer elements from s1 to s2 to reverse order
            while (s1.Count > 0)
            {
                s2.Push(s1.Pop());
            }
        }
        return s2.Pop();
    }

    // Dequeues and prints n elements
    static void ProcessQueue(int n)
    {
        Console.WriteLine("Dequeue elements: ");
        while (n > 0)
        {
            Console.WriteLine(Dequeue());
            n--;
        }
    }

    // Main method to read input and process the queue
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n=Convert.ToInt32(Console.ReadLine());

        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter Value: ");
            Enqueue(Convert.ToInt32(Console.ReadLine()));
        }

        ProcessQueue(n);
    }
}
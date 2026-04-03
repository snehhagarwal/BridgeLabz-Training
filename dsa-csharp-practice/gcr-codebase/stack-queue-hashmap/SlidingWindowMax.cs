using System;
using System.Collections.Generic;

// Finds sliding window maximum using deque
class SlidingWindowMax
{
    // Computes maximum for each window
    static void FindMaximum(int[] arr,int k)
    {
        // Deque to store indices
        LinkedList<int> deque=new LinkedList<int>();

        for(int i = 0; i < arr.Length; i++)
        {
            // Remove indices out of window
            if(deque.Count>0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }

            // Remove elements smaller than current
            while(deque.Count>0 && arr[deque.Last.Value] < arr[i])
            {
                deque.RemoveLast();
            }

            // Add current index to deque
            deque.AddLast(i);

            if (i >= k - 1)
            {
                // Print maximum of current window
                Console.Write(arr[deque.First.Value] + " ");
            }
        }
        }

    // Main method to read input
    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter Value: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter window size: ");
        int k=Convert.ToInt32(Console.ReadLine());

        FindMaximum(arr,k);
    }
}
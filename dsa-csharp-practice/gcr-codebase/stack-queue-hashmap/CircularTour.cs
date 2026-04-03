using System;
using System.Collections.Generic;

// Circular tour problem solver
class CircularTour
{
    // Find starting pump index
    static int FindStart(int[] petrol,int[] distance)
    {
        Queue<int> queue = new Queue<int>();

        int surplus=0;
        int count=0;
        int start=0;
        int n=petrol.Length;

        while(start<n)
        {
            // Accumulate petrol surplus
            surplus+=petrol[start]-distance[start];
            queue.Enqueue(start);
            count++;

            // Remove invalid starts
            while (surplus < 0 && queue.Count > 0)
            {
                int removed = queue.Dequeue();
                surplus -= petrol[removed] - distance[removed];
                count--;
            }

            // Check full tour
            if (count == n)
            {
                return queue.Peek();
            }

            start++;
        }
        return -1;
    }

    static void Main(string[] args)
    {
        // Input pump count
        Console.Write("Enter number of pumps: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] petrol=new int[n];
        int[] distance=new int[n];

        // Input petrol and distance
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter petrol: ");
            petrol[i]=Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter distance: ");
            distance[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Find start point
        int startPoint=FindStart(petrol,distance);

        // Output result
        if (startPoint == -1)
        {
            Console.WriteLine("No possible circular tour");
        }
        else
        {
            Console.WriteLine("Start tour from pump index: " + startPoint);
        }
    }
}
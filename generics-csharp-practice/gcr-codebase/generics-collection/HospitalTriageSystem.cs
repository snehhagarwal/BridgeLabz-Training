using System;
using System.Collections.Generic;

class HospitalTriageSystem
{
    public static void Main()
    {
        // Priority queue (higher severity first)
        PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

        // Input number of patients
        Console.Write("Enter number of patients: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            // Read patient details
            Console.Write("Enter patient name: ");
            string name = Console.ReadLine();

            Console.Write("Enter severity level: ");
            int severity = int.Parse(Console.ReadLine());

            // Enqueue with priority
            pq.Enqueue(name, -severity); // Negative for max-priority
        }

        // Process patients
        Console.WriteLine("\nTreatment Order:");
        while (pq.Count > 0)
        {
            Console.WriteLine(pq.Dequeue()); // Highest priority first
        }
    }
}

using System;
using System.Collections.Generic;
class BubbleSort
{
    // Sort array using bubble
    static void Sort(int[] arr)
    {
        int n=arr.Length;

        // Outer loop for passes
        for(int i = 0; i < n - 1; i++)
        {
            // Flag for swap check
            bool swapped=false;

            // Inner loop for comparisons
            for(int j = 0; j < n - i - 1; j++)
            {
                // Check if swap needed
                if (arr[j] > arr[j + 1])
                {
                    // Perform swap operation
                    int temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                    swapped=true;
                }
            }
            // Check for early exit
            if (!swapped)
            {
                break;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter no of students: ");
        // Read number of students
        int n=Convert.ToInt32(Console.ReadLine());

        // Initialize marks array
        int[] marks=new int[];
        // Loop to read marks
        for(int i = 0; i < n; i++)
        {
            Console.Write("aEnter marks: ");
            // Read and store mark
            marks[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Call sort function
        Sort(marks);

        // Output sorted marks header
        Console.WriteLine("Sorted marks: ");
        for(int i = 0; i < n; i++)
        {
            // Print each sorted mark
            Console.Write(marks[i] + " ");
        }
    }
}
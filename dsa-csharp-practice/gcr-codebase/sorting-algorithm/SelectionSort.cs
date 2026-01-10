using System;

class SelectionSort
{
    static void Sort(int[] arr)
    {
        // Iterate through each position
        for(int i = 0; i < arr.Length; i++)
        {
            // Set min to current index
            int min=i;
            // Find minimum in unsorted part
            for(int j = i + 1; j < arr.Length; j++)
            {
                // Check if smaller value found
                if (arr[j] < arr[min])
                {
                    // Update min index
                    min=j;
                }
            }

            // Swap minimum with current position
            int temp=arr[min];
            // Swap with current position
            arr[min]=arr[i];
            arr[i]=temp;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter number of students: ");
        // Read number of students
        int n=Convert.ToInt32(Console.ReadLine());

        int[] scores=new int[n];
        // Input scores loop
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter scores: ");
            scores[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Sort the scores
        Sort(scores);
        // Display sorted scores
        Console.WriteLine("Sorted Exams Scores: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(scores[i] + " ");
        }
    }
}
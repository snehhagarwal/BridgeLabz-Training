using System;

class CountingSort
{
    // Sorts array using counting
    static void Sort(int[] arr)
    {
        int min=10;
        int max=18;
        // Initialize count array
        int[] count=new int[max-min+1];

        // Count element frequencies
        for(int i = 0; i < arr.Length; i++)
        {
            count[arr[i]-min]++;
        }

        int idx=0;
        // Reconstruct sorted array
        for(int i = 0; i < count.Length; i++)
        {
            while(count[i] -- > 0)
            {
                arr[idx++]=i+min;
            }
        }
    }

    static void Main(string[] args)
    {
        // Read number of students
        Console.Write("Enter number of students: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] ages=new int[n];
        // Read student ages
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter age: ");
            ages[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Sort the ages
        Sort(ages);

        // Print sorted ages
        Console.WriteLine("Sorted ages: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(ages[i] + " ");
        }
    }
}
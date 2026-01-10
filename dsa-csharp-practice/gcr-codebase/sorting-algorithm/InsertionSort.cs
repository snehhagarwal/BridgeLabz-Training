using System;

class InsertionSort
{
    static void Sort(int[] arr)
    {
        // Iterate from second element
        for(int i = 1; i < arr.Length; i++)
        {
            // Set key to current
            int key=arr[i];
            int j=i-1;
            // Shift larger elements right
            while(j>=0 && arr[j] > key)
            {
                arr[j+1]=arr[j];
                j--;
            }
            // Insert key at position
            arr[j+1]=key;
        }
    }

    static void Main(string[] args)
    {
        // Get number of employees
        Console.Write("Enter number of employee: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] id=new int[n];
        // Read employee IDs
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter employee ID: ");
            id[i]=Convert.ToInt32(Console.ReadLine());
        }
        // Sort the IDs
        Sort(id);
        // Print sorted IDs
        Console.WriteLine("Sorted Employee Ids: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(id[i] + " ");
        }
    }
}
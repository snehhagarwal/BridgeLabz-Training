using System;

// Heap Sort Implementation
class HeapSort
{
    // Heapify subtree at i
    static void Func(int[] arr,int n,int i)
    {
        int largest=i;
        int left=2*i+1;
        int right=2*i+2;

        if(left<n && arr[left] > arr[largest])
        {
            largest=left;
        }

        if(right<n && arr[right] > arr[largest])
        {
            largest=right;
        }

        if (largest != i)
        {
            int temp=arr[i];
            arr[i]=arr[largest];
            arr[largest]=temp;

            Func(arr,n,largest);
        }
    }

    static void Sort(int[] arr)
    {
        int n=arr.Length;

        // Build max heap
        for(int i = n / 2 - 1; i >= 0; i--)
        {
            Func(arr,n,i);
        }

        // Extract elements from heap
        for(int i = n - 1; i >= 0; i--)
        {
            int temp=arr[0];
            arr[0]=arr[i];
            arr[i]=temp;

            Func(arr,i,0);
        }
    }

    static void Main(string[] args)
    {
        // Read number of applicants
        Console.Write("Enter number of applicants: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] salary=new int[n];
        // Read salaries from input
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter expected salary: ");
            salary[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Sort the salary array
        Sort(salary);

        Console.WriteLine("Sorted Salary: ");
        // Print sorted salary list
        for(int i = 0; i < n; i++)
        {
            Console.Write(salary[i] + " ");
        }
    }
}
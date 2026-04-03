using System;

class QuickSort
{
    // Partition function
    static int Part(int[] arr,int low,int high)
    {
        // Set pivot
        int pivot=arr[high];
        int i=low-1;

        // Iterate array
        for(int j = low; j < high; j++)
        {
            // Swap if smaller
            if (arr[j] < pivot)
            {
                i++;
                int temp=arr[i];
                arr[i]=arr[j];
                arr[j]=temp;
            }
        }

        // Place pivot
        int swap=arr[i+1];
        arr[i+1]=arr[high];
        arr[high]=swap;

        return i+1;
    }

    // Recursive sort function
    static void Sort(int[] arr,int low,int high)
    {
        if (low < high)
        {
            int pi=Part(arr,low,high);
            // Recurse on left part
            Sort(arr,low,pi-1);
            // Recurse on right part
            Sort(arr,pi+1,high);
        }
    }

    // Main method for execution
    static void Main(string[] args)
    {
        // Get number of products
        Console.Write("Enter number of Products: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] prices=new int[n];
        // Input product prices
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter Product Price: ");
            prices[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Sort the prices
        Sort(prices,0,n-1);

        // Display sorted prices
        Console.WriteLine("Sorted Product Prices: ");
        for(int i = 0; i < n; i++)
        {
            Console.Write(prices[i] + " ");
        }
    }
}

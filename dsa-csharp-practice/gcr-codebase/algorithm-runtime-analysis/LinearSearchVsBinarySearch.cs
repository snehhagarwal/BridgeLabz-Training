using System;
using System.Diagnostics;

// Compare Linear Search vs Binary Search performance for a sorted array
class LinearSearchVsBinarySearch{
    public static void Main(string[] args){
        int n = 1000000;
        int[] arr = new int[n];       // Create a sorted array

        for (int i = 0; i < n; i++)
            arr[i] = i;

        int target = n - 1;                    // Target to search
        Stopwatch sw = new Stopwatch();        // Stopwatch for timing

        // Linear Search 
        sw.Start();
        LinearSearch(arr, target);         
        sw.Stop();
        Console.WriteLine("Linear Search Time: " + sw.ElapsedMilliseconds + " ms");

        // Binary Search 
        sw.Restart();
        BinarySearch(arr, target);
        sw.Stop();
        Console.WriteLine("Binary Search Time: " + sw.ElapsedMilliseconds + " ms");
    }

    // Linear Search Method to find target
    static int LinearSearch(int[] arr, int target){
        for (int i = 0; i < arr.Length; i++)
            if (arr[i] == target)
                return i;
        return -1;
    }

    // Binary Search Method to find target
    static int BinarySearch(int[] arr, int target){
        int left = 0, right = arr.Length - 1;               // Initialize left and right pointers

        while (left <= right){                              // Binary search loop
            int mid = (left + right) / 2;                   // Calculate mid index

            if (arr[mid] == target)                         // Check if target is found
                return mid;
            else if (arr[mid] < target)                      // Check which side to search
                left = mid + 1;                             // Move left pointer
            else
                right = mid - 1;                             // Move right pointer
        }
        return -1;
    }
}

using System;

// Program to find first and last occurrence of a target in a sorted array
class FirstLast{
    static int FindFirst(int[] arr, int target){
        int low = 0, high = arr.Length - 1, result = -1;      // Initialize result

        while (low <= high) {                 // Binary search loop
            int mid = (low + high) / 2;      // Calculate mid index

            if (arr[mid] == target){           // Check if target is found
                result = mid;                  // Update result
                high = mid - 1;                 // Move high pointer to search left side
            }
            else if (arr[mid] < target)         // Check which side to search
                low = mid + 1;                   // Move low pointer
            else
                high = mid - 1;                  // Move high pointer
        }
        return result;
    }

    static int FindLast(int[] arr, int target){                
        int low = 0, high = arr.Length - 1, result = -1;        // Initialize result

        while (low <= high){                       // Binary search loop
            int mid = (low + high) / 2;            // Calculate mid index

            if (arr[mid] == target){                // Check if target is found
                result = mid;                       // Update result
                low = mid + 1;                      // Move low pointer to search right side
            }
            else if (arr[mid] < target)             // Check which side to search
                low = mid + 1;                      // Move low pointer
            else
                high = mid - 1;                      // Move high pointer
        }
        return result;
    }

    public static void Main(string[] args){
        // Get array size from user
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];          // Declare array

        Console.WriteLine("Enter sorted array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = int.Parse(Console.ReadLine());

        Console.Write("Enter target element: ");
        int target = int.Parse(Console.ReadLine());

        // Find and display first and last occurrence
        Console.WriteLine("First Occurrence: " + FindFirst(arr, target));
        Console.WriteLine("Last Occurrence: " + FindLast(arr, target));
    }
}
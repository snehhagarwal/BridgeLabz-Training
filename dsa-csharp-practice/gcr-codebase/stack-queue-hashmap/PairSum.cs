using System;
using System.Collections.Generic;

// Pair sum finder class
class PairSum
{
    // Checks for pair sum
    static bool HasPair(int[] arr,int target)
    {
        // Initialize hash map
        Dictionary<int,bool> map=new Dictionary<int, bool>();

        // Iterate through array
        for(int i = 0; i < arr.Length; i++)
        {
            // Check complement exists
            if (map.ContainsKey(target - arr[i]))
            {
                return true;
            }

            // Add current element
            map[arr[i]]=true;
        }

        return false;
    }

    // Program entry point
    static void Main(string[] args)
    {
        // Read array size
        Console.Write("Enter array size: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[n];
        // Read array elements
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter value: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        // Read target sum
        Console.Write("Enter target sum: ");
        int target=Convert.ToInt32(Console.ReadLine());

        // Print pair result
        Console.WriteLine(HasPair(arr,target));
    }
}
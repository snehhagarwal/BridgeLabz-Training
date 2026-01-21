using System;
using System.Collections;

class ReverseArrayList
{
    public static void Main()
    {
        // Initialize ArrayList
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };

        // Two pointers
        int left = 0;
        int right = list.Count - 1;

        // Reverse logic
        while (left < right)
        {
            object temp = list[left];   // Store left
            list[left] = list[right];   // Swap
            list[right] = temp;

            left++;                     // Move left
            right--;                    // Move right
        }

        // Output result
        Console.WriteLine("Reversed ArrayList:");
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}

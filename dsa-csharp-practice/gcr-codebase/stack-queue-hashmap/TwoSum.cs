using System;
using System.Collections.Generic;

class TwoSum
{
    static void Find(int[] arr,int target)
    {
        Dictionary<int,int> map=new Dictionary<int, int>();

        for(int i = 0; i < arr.Length; i++)
        {
            int diff=target-arr[i];

            if (map.ContainsKey(diff))
            {
                Console.WriteLine(map[diff] + " , " + i);
                return;
            }

            map[arr[i]]=i;
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter array size: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[n];
        for(int i = 0; i < n; i++)
        {
            Console.Write("Enter value: ");
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter target sum: ");
        int target=Convert.ToInt32(Console.ReadLine());
        
        Find(arr,target);
    }
}
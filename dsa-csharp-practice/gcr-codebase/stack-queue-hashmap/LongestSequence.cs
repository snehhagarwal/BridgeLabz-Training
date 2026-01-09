using System;
using System.Collections.Generic;

class LongestSequence
{
    static int Find(int[] arr)
    {
        Dictionary<int,bool> map=new Dictionary<int, bool>();

        //store all elements in dictionary
        for(int i = 0; i < arr.Length; i++)
        {
            if (!map.ContainsKey(arr[i]))
            {
                map[arr[i]]=true;
            }
        }

        int longest=0;

        //check longest consecutive sequence
        for(int i = 0; i < arr.Length; i++)
        {
            int num=arr[i];

            //start sequence
            if (!map.ContainsKey(num - 1))
            {
                int curr=num;
                int cnt=1;

                while (map.ContainsKey(curr + 1))
                {
                    curr++;
                    cnt++;
                }

                if (cnt > longest)
                {
                    longest=cnt;
                }
            }
        }

        return longest;
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

        Console.WriteLine(Find(arr));
    }
}
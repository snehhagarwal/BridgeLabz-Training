using System;

class PeakElement
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[n];

        Console.WriteLine("Enter array elements: ");
        for(int i = 0; i < n; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        int left=0;
        int right=n-1;

        while (left <= right)
        {
            int mid=(left+right)/2;

            if (arr[mid] <= arr[mid + 1])
            {
                left=mid+1;
            }
            else
            {
                right=mid;
            }
        }

        Console.WriteLine("Peak Element index: " + left);
        Console.WriteLine("Peak element value: " + arr[left]);
    }
}
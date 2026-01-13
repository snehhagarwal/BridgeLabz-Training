using System;

class RotationPoint
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of elements: ");
        int n=Convert.ToInt32(Console.ReadLine());

        int[] arr=new int[n];

        Console.WriteLine("Enter rotated sorted array: ");
        for(int i = 0; i < n; i++)
        {
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }

        int left=0;
        int right=n-1;

        while (left < right)
        {
            int mid=(left+right)/2;

            if (arr[mid] > arr[right])
            {
                left=mid+1;
            }
            else
            {
                right=mid;
            }
        }

        Console.WriteLine("Index is: " + left);
    }
}
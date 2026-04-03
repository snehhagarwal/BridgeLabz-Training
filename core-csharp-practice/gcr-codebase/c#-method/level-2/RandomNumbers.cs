using System;

class RandomNumbers
{
    static void Main(string[] args)
    {
        //random array generated
        int[] num=Generate4DigitRandomArray(5);
        double[] ans=FindAverageMinMax(nums);

        //printing statement 
        Console.WriteLine("Average: " + ans[0]);
        Console.WriteLine("Min: " + ans[1]);
        Console.WriteLine("Max: " + ans[2]);
    }

    static int[] Generate4DigitRandomArray(int size)
    {
        Random r=new Random();
        int[] arr=new int[size];
        for(int i = 0; i < size; i++)
        {
            arr[i]=r.Next(1000,10000);
        }
        return arr;
    }

    static double[] FindAverageMinMax(int[] arr)
    {
        int min=arr[0];
        int max=arr[0];
        int sum=0;

        for(int i = 0; i < arr.Length; i++)
        {
            //sum , min , max calculated
            sum+=arr[i];
            min=Math.Min(min,arr[i]);
            max=Math.Max(max,arr[i]);
        }

        //calculating the average
        double avg=(double)sum/arr.Length;
        return new double[]{avg,min,max};
    }

}
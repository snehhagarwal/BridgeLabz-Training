using System;
using System.Reflection.Metadata.Ecma335;

class NumberChecker
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //function call 
        int count=GetDigitCount(num);
        int[] digit=GetDigitsArray(num,count);

        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digit));
        Console.WriteLine("Is Armstrong Number" + IsArmstrongNumber(num,digit));

        int[] largest=GetLargest(digit);
        Console.WriteLine("Largest: "+ largest[0]);
        Console.WriteLine("Second Largest: "+ largest[1]);

        int[] smallest=GetSmallest(digit);
        Console.WriteLine("Smallest: " + smallest[0]);
        Console.WriteLine("Second Smallest: "+ smallest[1]);
         
    }

    public static int GetDigitCount(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        int count=0;
        int temp=n;
        while (temp > 0)
        {
            temp/=10;
            count++;
        }
    }

    public static int[] GetDigitsArray(int n,int cnt)
    {
        int[] arr=new int[cnt];
        for(int i = cnt - 1; i >= 0; i--)
        {
            arr[i]=n%10;
            n/=10;
        }
        return arr;
    }

    public static bool IsDuckNumber(int[] arr)
    {
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsArmstrongNumber(int original,int[] arr)
    {
        double sum=0;
        int p=arr.Length;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=Math.Pow(arr[i],p);
        }
        return (int)sum==original;
    }

    public static int[] GetLargest(int[] arr)
    {
        int first=int.MinValue;
        int second=int.MinValue;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > first)
            {
                second=first;
                first=arr[i];
            }
            else if(arr[i]>second && arr[i] != first)
            {
                second=arr[i];
            }
        }
        return new int[]{first,second};
    }

    public static int[] GetSmallest(int[] arr)
    {
        int first=int.MaxValue;
        int second=int.MaxValue;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < first)
            {
                second=first;
                first=arr[i];
            }else if(arr[i]<second && arr[i] != first)
            {
                second=arr[i];
            }
        }
        return new int[]{first,second};
    }
}
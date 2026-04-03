using System;

class NumberChecker3
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int[] arr=Store(number);

        Console.WriteLine("Digit Count: " + Count(number));
        Console.WriteLine("Palindrome Number: " + Palindrome(number));
        Console.WriteLine("Duck Number: " + Duck(number));

        Console.WriteLine("Original Digits");
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("Reversed Digits: ");
        int[] rev=Reverse(arr);
        for(int i = 0; i < rev.Length; i++)
        {
            Console.Write(rev[i] + " ");
        }
    }

    public static int Count(int num)
    {
        int count=0;
        while (num > 0)
        {
            count++;
            num/=10;
        }
        return count;
    }

    public static int[] Store(int num)
    {
        int count=Count(num);
        int[] arr=new int[count];

        for(int i = count - 1; i >= 0; i--)
        {
            arr[i]=num%10;
            num/=10;
        }
        return arr;
    }

    public static int[] Reverse(int[] arr)
    {
        int[] rev=new int[arr.Length];
        int j=0;

        for(int i = arr.Length - 1; i >= 0; i--)
        {
            rev[j]=arr[i];
            j++;
        }
        return rev;
    }

    public static bool Compare(int[] arr1,int[] arr2)
    {
        if(arr1.Length != arr2.Length)
        {
            return false;
        }
        for(int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                return false;
            }
        }
        return true;
    }

    public static bool Palindrome(int[] arr)
    {
        int[] rev=Reverse(arr);
        return Compare(arr,rev);
    }

    public static bool Duck(int[] arr)
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
}
using System;

class NumberChecker2
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int[] digit=Store(number);

        Console.WriteLine("Digit Count: " + Count(number));
        Console.WriteLine("Sum of Count: " + Sum(number));
        Console.WriteLine("Sum of Squares: " + Square(number));
        Console.WriteLine("Harshad Number: " + Harshad(number));

        int[,] freq=Digit(digit);
        Console.WriteLine("Digit Frequency: ");
        for(int i = 0; i < 10; i++)
        {
            if (freq[i, 1] > 0)
            {
                Console.WriteLine(freq[i,0] + " -> " + freq[i,1]);
            }
        }
    }

    public static int Count(int num)
    {
        int cnt=0;
        while (num > 0)
        {
            cnt++;
            num/=10;
        }
        return cnt;
    }
    public static int[] Store(int num)
    {
        int cnt=Count(num);
        int[] arr=new int[cnt];

        for(int i = cnt - 1; i >= 0; i--)
        {
            arr[i]=num%10;
            num/=10;
        }
        return arr;
    }

    public static int Sum(int[] arr)
    {
        int sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=arr[i];
        }
        return sum;
    }

    public static double Square(int[] arr)
    {
        double sum=0;
        for(int i = 0; i < arr.Length; i++)
        {
            sum+=Math.Pow(arr[i],2);
        }
        return sum;
    }

    public static bool Harshad(int num,int[] arr)
    {
        int sum=Sum(arr);
        return num%sum==0;
    }

    public static int[,] Digit(int[] arr)
    {
        int[,] freq=new int[10,2];

        for(int i = 0; i < 10; i++)
        {
            freq[i,0]=i;
        }
        for(int i = 0; i < arr.Length; i++)
        {
            freq[arr[i],1]++;
        }
        return freq;
    }
}
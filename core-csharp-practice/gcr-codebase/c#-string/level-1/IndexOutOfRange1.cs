using System;

class IndexOutOfRange1
{
    static void Main(string[] args)
    {
        try
        {
            int[] arr={1,2,3,4};
             Console.WriteLine(arr[10]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException found");
        }
    }
}
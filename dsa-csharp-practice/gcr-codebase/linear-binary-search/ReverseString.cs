using System;
using System.Text;

class ReverseString
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input=Console.ReadLine();

        StringBuilder sb=new StringBuilder(input);

        int start=0;
        int end=sb.Length-1;

        while (start < end)
        {
            char temp=sb[start];
            sb[start]=sb[end];
            sb[end]=temp;

            start++;
            end--;
        }

        Console.WriteLine("Reverse String is: " + sb.ToString());
    }
}
using System;
using System.Text;

class ConcatenateString
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of string: ");
        int n=Convert.ToInt32(Console.ReadLine());

        StringBuilder sb=new StringBuilder();

        Console.WriteLine("Enter string: ");
        for(int i = 0; i < n; i++)
        {
            sb.Append(Console.ReadLine());
        }

        Console.WriteLine("Concatenated String: " + sb);
    }
}
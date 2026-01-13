using System;
using System.Text;

class RemoveDuplicates
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the string: ");
        string str=Console.ReadLine();

        StringBuilder sb=new StringBuilder();

        for(int i = 0; i < str.Length; i++)
        {
            if (!sb.ToString().Contains(str[i]))
            {
                sb.Append(str[i]);
            }
        }

        Console.WriteLine("String after removing duplicates: " + sb);
    }
}
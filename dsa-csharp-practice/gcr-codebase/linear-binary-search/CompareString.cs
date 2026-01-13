using System;
using System.Diagnostics;
using System.Text;

class CompareString
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of times: ");
        int n=Convert.ToInt32(Console.ReadLine());

        Stopwatch sw=new Stopwatch();
        sw.Start();

        StringBuilder sb=new StringBuilder();
        for(int i = 0; i < 100000; i++)
        {
            sb.Append("A");
        }
        sw.Stop();

        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
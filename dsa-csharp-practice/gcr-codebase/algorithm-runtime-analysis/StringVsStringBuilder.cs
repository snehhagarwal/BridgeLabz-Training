using System;
using System.Diagnostics;
using System.Text;

// Compare String vs StringBuilder performance for concatenation
class StringVsStringBuilder {
    public static void Main(string[] args){
        int n = 10000;
        Stopwatch sw = new Stopwatch();

        // String Concatenation
        sw.Start();       
        string s = "";
        for (int i = 0; i < n; i++)
            s += "a";                       
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");

        // StringBuilder Concatenation
        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("a");
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}

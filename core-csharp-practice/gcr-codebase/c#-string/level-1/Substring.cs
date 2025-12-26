using System;

class Substring
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the string: ");
        string str=Console.ReadLine();

        Console.Write("Enter start index: ");
        string start=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the end index: ");
        string end=Convert.ToInt32(Console.ReadLine());

        //function call and built in for substring
        string custom=Create(str,start,end);
        string builtIn=str.Substring(start,end-start);

        Console.WriteLine("Custom Substring: " + custom);
        Console.WriteLine("Built-In Substring: " + builtIn);
    }

    static string Create(string str,int s,int e)
    {
        string result="";
        for(int i = s; i < e; i++)
        {
            result+=str[i];
        }
        return result;
    }
}
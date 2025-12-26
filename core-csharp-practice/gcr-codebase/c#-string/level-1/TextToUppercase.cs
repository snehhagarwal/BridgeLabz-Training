using System;
using System.Runtime.CompilerServices;
using Microsoft.Win32.SafeHandles;

class TextToUppercase
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the text: ");
        string str=Console.ReadLine();

        //function call and built in 
        string s=Custom(str);
        string s1=str.ToUpper();

        Console.WriteLine("Custom Uppercase: " + s);
        Console.WriteLine("Built-In Uppercase: " + s1);

    }

    //function for custom uppercase
    static string Custom(string str)
    {
        string result="";
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i]>='a' && str[i] <= 'z')
            {
                result+=(char)(str[i]-32);
            }
            else
            {
                result+=str[i];
            }
        }
        return result;
    }
}
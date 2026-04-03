using System;

class TextToLowercase
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the text: ");
        string str=Console.ReadLine();

        //function call and built in method
        string s1=Custom(str);
        string s2=str.ToLower();

        Console.WriteLine("Custom Lowercase: " + s1);
        Console.WriteLine("Biult-In Lowercase: " + s2);
    }

    static string Custom(string s)
    {
        string result="";
        for(int i = 0; i < s.Length; i++)
        {
            if(s[i]>='A' && s[i] <= 'Z')
            {
                result+=(char)(s[i]+32);
            }
            else
            {
                result+=s[i];
            }
        }
        return result;
    }
}
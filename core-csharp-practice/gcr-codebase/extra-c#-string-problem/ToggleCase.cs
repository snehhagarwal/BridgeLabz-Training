using System;

class ToggleCase
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a string: ");
        string str=Console.ReadLine();

        //final string
        string ans="";

        for(int i = 0; i < str.Length; i++)
        {
            char c=str[i];

            if(c>='A' && c <= 'Z')
            {
                ans+=(char)(c+32);
            }else if(c>='a' && c <= 'z')
            {
                ans+=(char)(c-32);
            }
            else
            {
                ans+=c;
            }
        }

        //printing statement
        Console.WriteLine("Toggled String: " + ans);
    }
}
using System;

class RemoveChar
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a string: ");
        string str=Console.ReadLine();

        //type the char to be removed
        Console.Write("Enter the character to be removed: ");
        char ch=Console.Read();

        string ans="";

        for(int i = 0; i < str.Length; i++)
        {
            if (str[i] != ch)
            {
                ans+=str[i];
            }
        }

        //printing statement
        Console.WriteLine("Modified String: " + ans);
    }
}
using System;

class AllCharacter
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the string: ");
        string str=Console.ReadLine();

        //function call for custom and then using built in 
        char[] custom=GetChar(str);
        char[] builtIn=str.ToCharArray();

        Console.WriteLine("Custom Result: ");
        for(int i = 0; i < custom.Length; i++)
        {
            Console.Write(custom[i] + " ");
        }

        Console.WriteLine("\nBuilt-In Results: ");
        for(int i = 0; i < builtIn.Length; i++)
        {
            Console.Write(builtIn[i] + " ");
        }
    }

    static char[] GetChar(string str)
    {
        char[] chars=new char[str.Length];
        for(int i = 0; i < str.Length; i++)
        {
            chars[i]=str[i];
        }
        return chars;
    }
}
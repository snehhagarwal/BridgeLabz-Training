using System;

class Palindrome
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the string: ");
        string str=Console.ReadLine();

        //function call 
        if (isPalindrome(str))
        {
            Console.WriteLine("Palindrome");
        }
        else
        {
            Console.WriteLine("Not Palindrome");
        }
    }

    public static bool isPalindrome(string s)
    {
        //reverse string
        string reverse="";
        for(int i = s.Length - 1; i >= 0; i--)
        {
            reverse+=s[i];
        }

        //built-in function 
        if (s.Equals(reverse))
        {
            return true;
        }
        return false;
    }
}
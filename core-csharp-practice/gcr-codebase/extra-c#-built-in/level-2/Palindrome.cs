using System;

class Palindrome
{
    static void Main(string[] args)
    {
        //take input from user
        Console.Write("Enter a string: ");
        string input=Console.ReadLine();

        if (isPalindrome(input))
        {
            Console.WriteLine("Palidrome");
        }
        else
        {
            Console.WriteLine("Not A Palindrome");
        }
    }

    static bool isPalindrome(string str)
    {
        int left=0;
        int right=str.Length-1;

        while (left < right)
        {
            if (str[left] != str[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
}
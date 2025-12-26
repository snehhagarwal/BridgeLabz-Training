using System;

class Anagram
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the first string: ");
        string s1=Console.ReadLine();

        Console.Write("Enter the second string: ");
        string s2=Console.ReadLine();

        //checking the length 
        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Not Anagrams");
            return;
        }

        //frequency array
        int[] freq=new int[256];
        for(int i = 0; i < s1.Length; i++)
        {
            freq[s1[i]]++;
            freq[s2[i]]--;
        }

        //if no value is 0 then false
        for(int i = 0; i < 256; i++)
        {
            if (freq[i] != 0)
            {
                Console.WriteLine("Not Anagram");
                return;
            }
        }

        Console.WriteLine("Strings are Anagrams");
    }
}
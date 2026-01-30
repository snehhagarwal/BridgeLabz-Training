using System;
using System.Collections.Generic;

class WordPuzzle
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first word: ");
        string s1=Console.ReadLine();

        //edge case checking whether word has more than one word
        string str1=s1.Trim().Split(' ');
        if (str1.Length > 1)
        {
            Console.WriteLine("Invalid word");
            return;
        }

        Console.Write("Enter the second word: ");
        string s2=Console.ReadLine();

        //edge case if second word has more than one word
        string str2=s2.Trim().Split(' ');
        if (str2.Length > 1)
        {
            Console.WriteLine("Invalid word");
            return;
        }
        
        //checking first word is reverse of second word
        char[] arr=s1.ToLower().ToCharArray();
        Array.Reverse(arr);
        string reversed=new string(arr);

        if (reversed.Equals(s2.ToLower()))
        {
            //replace vowel with @
            string result=reversed;
            foreach(char v in "aeiou")
            {
                result=result.Replace(v,'@');
            }
            Console.WriteLine(result);
        }
        else
        {
            //combine and convert to uppercase
            string combined=(s1+s2).ToUpper();
            HashSet<char> vowels=new HashSet<char>{'A','E','I','O','U'};
            int vowelcnt=0;
            int consonant=0;

            foreach(char c in combined)
            {
                if (vowels.Contains(c))
                {
                    vowelcnt++;
                }else if (char.IsLetter(c))
                {
                    consonant++;
                }
            }

            if (vowelcnt > consonant)
            {
                Print(combined,vowels,true);
            }else if (consonant > vowelcnt)
            {
                Print(combined,vowels,false);
            }
            else
            {
                Console.WriteLine("Vowels and consonants are equal");
            }
        }
    }

    static void Print(string word,HashSet<char> vowels,bool want)
    {
        HashSet<char> printed=new HashSet<char>();
        string output="";
        foreach(char c in word)
        {
            bool isVowel = vowels.Contains(c);
            if(isVowel==want && !printed.Contains(c))
            {
                output+=c;
                printed.Add(c);
                if (output.Length == 2)
                {
                    break;
                }
            }
        }

        Console.WriteLine(output);
    }
}
using System;

class LongestWord
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a sentence: ");
        string sentence=Console.ReadLine();

        string longest="";
        string word="";

        //loop to find the longest word
        for(int i = 0; i <= sentence.Length; i++)
        {
            if(i==sentence.Length || sentence[i]==' ')
            {
                if(word.Length > longest.Length)
                {
                    longest=word;
                }
                word="";
            }
            else
            {
                word+=sentence[i];
            }
        }

        Console.WriteLine("Longest Word: " + longest);
    }
}
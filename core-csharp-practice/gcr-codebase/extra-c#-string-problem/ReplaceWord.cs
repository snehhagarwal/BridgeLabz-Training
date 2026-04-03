using System;

class ReplaceWord
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter sentence: ");
        string sentence=Console.ReadLine();

        Console.Write("Word To replace: ");
        string old=Console.ReadLine();

        Console.Write("New word: ");
        string newWord=Console.ReadLine();
    
        //final string and word 
        string ans="";
        string word="";

        for(int i = 0; i <= sentence.Length; i++)
        {
            if(i==sentence.Length || sentence[i]==' ')
            {
                if (word.Equals(old))
                {
                    ans+=newWord+" ";
                }
                else
                {
                    ans+=word+" ";
                }
                word="";
            }
            else
            {
                word+=sentence[i];
            }
        }
        
        //printing statement
        Console.WriteLine("Modified Sentence: " + ans.Trim());

    }
}
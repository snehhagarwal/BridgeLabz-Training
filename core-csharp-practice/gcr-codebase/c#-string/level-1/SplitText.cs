using System;

class SplitText
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the text: ");
        string str=Console.ReadLine();

        //function call 
        string[,] words=Split(str);

        Console.WriteLine("Word   Length");
        for(int i = 0; i < 50; i++)
        {
            if (words[i, 0] != null)
            {
                Console.WriteLine(words[i,0] + "   " + words[i,1]);
            }
        }
    }

    //function for calculating the length
    static int GetLength(string str)
    {
        int cnt=0;
        for(int i = 0; i < str.Length; i++)
        {
            cnt++;
        }
        return cnt;
    }

    //function that creates an array which stores the word and its length 
    static string[,] Split(string s)
    {
        string[,] ans=new string[50,2];
        string word="";
        int idx=0;

        for(int i = 0; i <= GetLength(s); i++)
        {
            if(i==GetLength(s) || s[i]==' ')
            {
                if (word != "")
                {
                    ans[idx,0]=word;
                    ans[idx,1]=GetLength(word).ToString();
                    idx++;
                    word="";
                }
            }
            else
            {
                word+=s[i];
            }
        }
        return ans;
    }
}
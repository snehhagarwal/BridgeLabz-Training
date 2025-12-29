using System;
using System.Xml;

class SentenceFormat
{
    static void Main(string[] args)
    {
        //menu is called 
        Menu();
    }

    static void Menu()
    {
        //choice to be chosen 
        int choice;

        do
        {
            //menu for the game 
            Console.WriteLine("\nMenu for the game: \n");
            Console.WriteLine("1. Format Paragraph");
            Console.WriteLine("2.Analyze Paragraph");
            Console.WriteLine("3. Exit");
            Console.Write("Enter the choice: ");
            choice=Convert.ToInt32(Console.ReadLine());

            //switch case according to the choice
            switch (choice)
            {
                //formatting function being called 
                case 1:
                   Format();
                   break;
                case 2:
                   //analyze function being called 
                   Analyze();
                   break;
                case 3:
                   //quitting the program 
                   Console.WriteLine("Exit the program.");
                   break;
                default:
                   //no choice from the menu was made 
                   Console.WriteLine("Invalid choice.");
                   break;
            }
        }while(choice!=3);  
    }

    //function for formatting
    static void Format()
    {
        //taking input from the user
        Console.Write("\nEnter the paragraph: ");
        string str=Console.ReadLine();

        //formatting function being called 
        string ans=FormatPara(str);
        Console.WriteLine("\n Formatted Paragraph");
        //printing the result 
        Console.WriteLine(ans);
    }

    static string FormatPara(string str)
    {
        //checking if the input was just spaces or empty with no word
        if (IsEmpty(str))
        {
            return "Input is empty";
        }

        string ans="";
        //boolean value to check if next letter must be capital
        bool capital=true;
        //boolean value to check if space must be allowed or not 
        bool space=false;

        for(int i = 0; i < str.Length; i++)
        {
            char ch=str[i];

            //check if it is a space
            if(ch==' ')
            {
                if (space)
                {
                    ans+=ch;
                    space=false;
                }
                continue;
            }

            //capitalize first word of each sentence
            if(capital && IsLetter(ch))
            {
                //capitalize the character 
                ans+=ToUpper(ch);
                capital=false;
            }
            else
            {
                //if not to be capitalized simply add in string 
                ans+=ch;
            }

            space=true; //space after a word 

            if(ch=='.' || ch=='?' || ch == '!')
            {
                //space added after punctuation marks
                ans+=' ';
                //after punctuation capital letter 
                capital=true;
                //no space after capital letter 
                space=false;
            }
        }
        return ans;
    }

    static bool IsEmpty(string str)
    {
        //checking if the string is empty or has only spaces 
        for(int i = 0; i < str.Length; i++)
        {
            if(str[i]!=' ')
            {
                return false;
            }
        }
        return true;
    }

    //checking of the character is alphabet only 
    static bool IsLetter(char c)
    {
        return (c>='a' && c<='z') || (c>='A' && c<='Z');
    }

    //changing to uppercase 
    static char ToUpper(char c)
    {
        if(c>='a' && c <= 'z')
        {
            return (char)(c-32);
        }
        return c;
    }

    //checking if both the strings are equal if strings are equal then it will be replaced 
    static bool IsEqual(string a,string b)
    {
        if (a.Length != b.Length)
        {
            return false;
        }
        for(int i = 0; i < a.Length; i++)
        {
            char c1=a[i];
            char c2=b[i];

            if(c1>='A' && c1 <= 'Z')
            {
                //changing in lowercase 
                c1=(char)(c1+32);
            }
            if(c2>='A' && c2 <= 'Z')
            {
                c2=(char)(c2+32);
            }

            //checking the characters
            if (c1 != c2)
            {
                return false;
            }
        }
        return true;
    }

    static void Analyze()
    {
        Console.Write("\nEnter paragraph: ");
        string str=Console.ReadLine();

        if (IsEmpty(str))
        {
            Console.WriteLine("Paragraph is empty.");
            return;
        }

        Console.WriteLine("Word Count: " + CountWord(str));
        Console.WriteLine("Longest Word: " + LongestWord(str));

        Console.Write("\n Enter word to replace");
        string old=Console.ReadLine();

        Console.Write("Enter new word: ");
        string newWord=Console.ReadLine();

        Console.WriteLine("\nUpdated Paragraph");
        Console.WriteLine(ReplaceWord(str,old,newWord));

    }

    static int CountWord(string text)
    {
        int count=0;
        bool inWord=false;

        for(int i = 0; i < text.Length; i++)
        {
            if(text[i]!=' ' && !inWord)
            {
                count++;
                inWord=true;
            }
            else if(text[i]==' ')
            {
                inWord=false;
            }
        }
        return count;
    }

    static string LongestWord(string str)
    {
        string longest="";
        string current="";

        for(int i = 0; i <= str.Length; i++)
        {
            if(i<str.Length && str[i]!=' ')
            {
                current+=str[i];
            }
            else
            {
                if (current.Length > longest.Length)
                {
                    longest=current;
                }
                current="";
            }
        }
        return longest;
    }

    static string ReplaceWord(string str,string old,string newWord)
    {
        string ans="";
        string current="";
        for(int i = 0; i <= str.Length; i++)
        {
            if(i<str.Length && str[i]!=' ')
            {
                current+=str[i];
            }
            else
            {
                if (IsEqual(current, old))
                {
                    ans+=newWord;
                }
                else
                {
                    ans+=current;
                }
                if (i < str.Length)
                {
                    ans+=' ';
                }
                current="";
            }
        }
        return ans;
    }
}
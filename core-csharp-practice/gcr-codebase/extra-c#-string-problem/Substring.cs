using System;

class Substring
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the string: ");
        string str=Console.ReadLine();

        Console.Write("Enter the subtsring: ");
        string sub=Console.ReadLine();

        //counting the occurence
        int cnt=0;
     
        for(int i = 0; i <= str.Length; i++)
        {
            int j;
            for(int j = 0; j < sub.Length; j++)
            {
                if (str[i + j] != sub[j])
                {
                    break;
                }

                if (j == sub.Length)
                {
                    cnt++;
                }
            }
        }

        //printing statement 
        Console.WriteLine("Occurences: " + cnt);
    }
}
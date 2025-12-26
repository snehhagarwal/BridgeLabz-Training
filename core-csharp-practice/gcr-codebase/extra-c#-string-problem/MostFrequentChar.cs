using System;

class MostFrequentChar
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a string: ");
        string str=Console.ReadLine();

        //most frequent char 
        char max=str[0];
        int maxcnt=0;

        for(int i = 0; i < str.Length; i++)
        {
            int count=0;  //count the frequency
            for(int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                }
            }

            if (count > maxcnt)
            {
                maxcnt=count;
                max=str[i];
            }
        }
        
        //printing statement 
        Console.WriteLine("Most Frequent Character: " + max + " ");
    }
}
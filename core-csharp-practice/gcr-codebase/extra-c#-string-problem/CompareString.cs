using System;

class ComapreString
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the first string: ");
        string s1=Console.ReadLine();

        Console.Write("Enter the second string: ");
        string s2=Console.ReadLine();

        int minLen=s1.Length<s2.Length ? s1.Length : s2.Length;
        bool isDiff=false;

        for(int i = 0; i < minLen; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine("\"" + s1 + "\" comes before \"" + s2 +"\"");
                isDiff=true;
                break;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine("\"" + "\" comes before \"" + s1 + "\"");
                isDiff=true;
                break;
            }
        }

        if (!isDiff)
        {
            if (s1.Length < s2.Length)
            {
                Console.WriteLine("\"" + s1 + "\" comes before \"" + s2 + "\"");
            }else if (s1.Length > s2.Length)
            {
                Console.WriteLine("\"" + s2 + "\" comes before \"" + s1 + "\"");
            }
            else
            {
                Console.WriteLine("Both strings are equal");
            }
        }
    }
}
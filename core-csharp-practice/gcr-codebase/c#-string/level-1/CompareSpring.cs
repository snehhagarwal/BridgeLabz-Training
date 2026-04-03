using System;

class CompareSpring
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the first string: ");
        string s1=Console.ReadLine();

        Console.Write("Enter the second string: ");
        string s2=Console.ReadLine();

        //function call and compare
        bool custom=Compare(s1,s2);
        bool builtIn=s1.Equals(s2);

        Console.WriteLine("Custom comparison result: " + custom);
        Console.WriteLine("Built-in Equal Result: " + builtIn);
    }

    static bool Compare(string s1,string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        for(int i = 0; i < s1.Length; i++)
        {
            if (s1[i] != s2[i])
            {
                return false;
            }
        }
        return true;
    }

}
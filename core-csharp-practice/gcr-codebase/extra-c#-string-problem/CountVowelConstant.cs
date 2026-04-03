using System;

class CountVowelConstant
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a string: ");
        string str=Console.ReadLine().ToLower();
        
        //to store the count 
        int vowel=0;
        int constant=0;

        for(int i = 0; i < str.Length; i++)
        {
            char c=str[i];
            if(c>='a' && c <= 'z')
            {
                if(c=='a' || c=='e' || c=='i' || c=='o' || c == 'u')
                {
                    vowel++; //if vowel increment
                }
                else
                {
                    constant++; //if constant increment
                }
            }
        }

        //printing statement 
        Console.WriteLine("Vowels: " + vowel);
        Console.WriteLine("Constants: " + constant);
    }
}
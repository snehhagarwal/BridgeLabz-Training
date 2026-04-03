using System;

class ReverseString
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter a string: ");
        string str=Console.ReadLine();
        string reverse="";

        //loop for reversing the string
        for(int i = str.Length - 1; i >= 0; i--)
        {
            reverse+=str[i];
        }

        //printing statement 
        Console.WriteLine("Reversed String: " + reverse);
    }
}
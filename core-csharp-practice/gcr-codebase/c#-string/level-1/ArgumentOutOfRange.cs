using System;

class ArgumentOutOfRange
{
    static void Main(string[] args)
    {
        //using try and catch for exception handling
        try
        {
            string str="Hello";
            Console.WriteLine(str.Substring(6,10));
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine("ArgumentOutOfRangeException found");
        }
    }
}
using System;

class IndexOutOfRange
{
    static void Main(string[] args)
    {
        //using try and catch for exception handling
        try
        {
            string str="Hello";
            Console.WriteLine(str[10]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("IndexOutOfRangeException found");
        }
    }
}
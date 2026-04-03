using System;

class FormatException
{
    static void Main(string[] args)
    {
        //using try and catch for exception handling 
        try
        {
            string str="hello";
            int n=Convert.ToInt32(str);
        }
        catch (FormatException e)
        {
            Console.WriteLine("FormatException found");
        }
    }
}
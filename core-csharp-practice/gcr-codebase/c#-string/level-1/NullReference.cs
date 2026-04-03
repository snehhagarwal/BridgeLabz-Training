using System;

class NullReference
{
    static void Main(string[] args)
    {
        //exception handling using try catch 
        try
        {
            string str=null;
            Console.WriteLine(str.Length);
        }
        catch(NullReferenceException e)
        { 
             Console.WriteLine("NullReferenceException found");
        }
    }
}
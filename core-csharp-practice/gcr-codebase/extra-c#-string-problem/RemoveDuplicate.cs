using System;

class RemoveDuplicate
{
    static void Main(string[] args)
    {
        //take input from the user
        string str=Console.ReadLine();
        string result="";

        //for removing duplicates
        for(int i = 0; i < str.Length; i++)
        {
            bool isDuplicate=false;

            for(int j = 0; j < result.Length; i++)
            {
                if (str[i] == result[j])
                {
                    isDuplicate=true;
                    break;
                }
            }

            //if not duplicate
            if (!isDuplicate)
            {
                result+=str[i];
            }
        }
        
        Console.WriteLine("String Without duplicates: " + result);
    }
}
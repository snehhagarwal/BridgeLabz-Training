using System;

class SentenceSearch
{
    static void Main(string[] args)
    {
        Console.Write("Enter number of sentences: ");
        int n=Convert.ToInt32(Console.ReadLine());

        string[] arr=new string[n];

        Console.WriteLine("Enter sentence: ");
        for(int i = 0; i < n; i++)
        {
            arr[i]=Console.ReadLine();
        }

        Console.Write("Enter words to search: ");
        string word=Console.ReadLine();

        for(int i = 0; i < n; i++)
        {
            if (arr[i].Contains(word))
            {
                Console.WriteLine("Found in: " + arr[i]);
                return;
            }
        }
        Console.WriteLine("Word not found");
    }
}
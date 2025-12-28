using System;

class NumberGuessing
{
    static void Main(string[] args)
    {
        int low=1;
        int high=100;
        string feedback;

        Console.WriteLine("Think of a number between 1 and 100.");

        while (true)
        {
            int guess=GenerateGuess(low,high);

            Console.WriteLine("Computer guesses: " + guess);

            feedback=GetFeedback();

            if (feedback == "c")
            {
                Console.WriteLine("Computer guesses correctly!");
                break;
            }
            else if (feedback == "h")
            {
                high=guess-1;
            }else if (feedback == "l")
            {
                low=guess+1;
            }
        }
    }

    //function to generate guess
    static int GenerateGuess(int low,int high)
    {
        return (low+high)/2;
    }

    //get feedback from user
    static string GetFeedback()
    {
        Console.Write("Is the guess High,Low or Correct(h,l,c)? ");
        return Console.ReadLine().ToLower();
    }
}
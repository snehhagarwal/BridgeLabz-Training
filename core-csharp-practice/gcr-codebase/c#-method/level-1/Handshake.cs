using System;

class Handshake
{
    static void Main(string[] args)
    {
        //take input from the user
        Console.Write("Enter the number of students: ");
        int n=Convert.ToInt32(Console.ReadLine());

        //function for calculation 
        int handshake=func(n);

        //printing statement 
        Console.WriteLine("Maximum Handshakes: " + handshake);
    }

    static int func(int n)
    {
        //formula
        int ans=(n*(n-1))/2;
        return ans;
    }
}
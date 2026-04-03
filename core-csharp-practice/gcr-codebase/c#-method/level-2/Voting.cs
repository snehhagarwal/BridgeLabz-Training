using System;

class Voting
{
    static void Main(string[] args)
    {
        //taking input from the user
        int[] ages=new int[10];

        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter the age of student: ");
            ages[i]=Convert.ToInt32(Console.ReadLine());

            if (CanStudentVote(ages[i]))
            {
                Console.WriteLine("Can Vote");
            }
            else
            {
                Console.WriteLine("Cannot Vote");
            }
        }

    }

    public static bool CanStudentVote(int age)
    {
        if (age < 18)
        {
            return false;
        }
        return true;
    }
}
using System;

class StudentScore
{
    static int[] scores=new int[100];
    static int count=0;

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\n Student Score Menu");
            Console.WriteLine("1. Enter the number of Students");
            Console.WriteLine("2. Enter the scores");
            Console.WriteLine("3. Show the average score");
            Console.WriteLine("4. Show Highest and Lowest Score");
            Console.WriteLine("5. Show Scores Above Average");
            Console.WriteLine("6. Exit ");

            Console.Write("Choose an option: ");

            int choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    StudentEntry();
                    break;
                case 2:
                    Scores();
                    break;
                case 3:
                    DisplayAvg();
                    break;
                case 4:
                    HighLow();
                    break;
                case 5:
                    AboveAvg();
                    break;
                case 6:
                    Console.WriteLine("Thank you ");
                    return;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
    }
    static void StudentEntry()
    {
        Console.Write("Enter number of students: ");
        count=Convert.ToInt32(Console.ReadLine());

        if(count<=0 || count > 100)
        {
            Console.WriteLine("Invalid number of students");
            count=0;
            return;
        }

        Array.Clear(scores,0,scores.Length);
        Console.WriteLine("Data stored successfully");
    }

    static void Scores()
    {
        if (count == 0)
        {
            Console.WriteLine("Please enter number of students first");
            return;
        }

        for(int i = 0; i < count; i++)
        {
            Console.Write("Enter score of student: " + (i+1) + ": ");
            scores[i]=Convert.ToInt32(Console.ReadLine());

            while (scores[i] < 0)
            {
                Console.WriteLine("Score is less than 0. Re-Enter: ");
                scores[i]=Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("Data saved successfully");
    }

    static float Average()
    {
        if (count == 0)
        {
            return 0;
        }
        int total=0;
        for(int i = 0; i < count; i++)
        {
            total+=scores[i];
        }
        return (float)total/count;
    }

    static void DisplayAvg()
    {
        if (count == 0)
        {
            Console.WriteLine("Enter the score first. ");
            return;
        }

        Console.WriteLine("Average Score: " + Average());
    }

    static void HighLow()
    {
        if (count == 0)
        {
            Console.WriteLine("Enter the score first");
            return;
        }

        int max=scores[0];
        int min=scores[0];

        for(int i = 1; i < count; i++)
        {
            if (scores[i] > max)
            {
                max=scores[i];
            }
            if (scores[i] < min)
            {
                min=scores[i];
            }
        }

        Console.WriteLine("Highest Score is: " + max);
        Console.WriteLine("Lowest Score is: " + min);
    }

    static void AboveAvg()
    {
        if (count == 0)
        {
            Console.WriteLine("Enter the score first.");
            return;
        }

        float avg=Average();
        Console.WriteLine("Scores above Average are: ");

        for(int i = 0; i < count; i++)
        {
            if (scores[i] > avg)
            {
                Console.WriteLine(scores[i]);
            }
        }
    }

}
using System;

class TemperatureAnalyzer
{
    static float[,] arr=new float[7,24];
    static void Main(string[] args)
    {
        Random r=new Random();

        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                arr[i,j]=r.Next(0,41);
            }
        }

        int choice;
        do
        {
            Console.WriteLine("\n Menu for the program");
            Console.WriteLine("1. Find the Hottest Day");
            Console.WriteLine("2. Find  the coldest day");
            Console.WriteLine("3. Average Temperature per day");
            Console.WriteLine("4. Exit");

            Console.Write("Enter your choice");
            choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                     FindHottest();
                     break;
                case 2: 
                    FindColdest();
                    break;
                case 3:
                    Average(arr);
                    break;
                case 4:
                    Console.WriteLine("Program Finished");
                    break;
                default: 
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }while(choice!=4);
    }

    static void FindHottest()
    {
        float max=arr[0,0];
        int day=0;
        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                if (arr[i, j] > max)
                {
                    max=arr[i,j];
                    day=i;
                }
            }
        }

        Console.WriteLine("Hottest Day is: " + (day+1));
    }

    static void FindColdest()
    {
        float min=arr[0,0];
        int day=0;
        for(int i = 0; i < 7; i++)
        {
            for(int j = 0; j < 24; j++)
            {
                if (arr[i, j] < min)
                {
                    min=arr[i,j];
                    day=i;
                }
            }
        }
        Console.WriteLine("Coldest Day is: " + (day+1));
    }

    static void Average(float[,] temp)
    {
        for(int i = 0; i < 7; i++)
        {
            float sum=0;
            for(int j = 0; j < 24; j++)
            {
                sum+=temp[i,j];
            }
            Console.WriteLine("Day" + (i+1) + " Average = " + (sum/24) + " degree celsius");
        }
    }
}
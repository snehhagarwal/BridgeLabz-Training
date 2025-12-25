using System;
using System.Globalization;

class StudentScorecard
{
    static void Main(string[] args)
    {
        //take input from the user 
        Console.Write("Enter the number: ");
        int student=Convert.ToInt32(Console.ReadLine());

        int[,] score=Generate(student);
        double[,] result=Calculate(score,student);

        Console.WriteLine("Student Scorecard");
        Display(score,result,student);
    }

    // b) Method to generate random PCM scores
    static int[,] Generate(int student)
    {
        int[,] scores=new int[student,3];
        Random r=new Random();

        for(int i = 0; i < student; i++)
        {
            scores[i,0]=r.Next(10,100);
            scores[i,1]=r.Next(10,100);
            scores[i,2]=r.Next(10,100);
        }
        return scores;
    }

    // c) Method to calculate total, average, percentage
    static double[,] Calculate(int[,] scores,int student)
    {
        double[,] result=new double[student,3];

        for(int i = 0; i < student; i++)
        {
            int total=scores[i,0]+scores[i,1]+scores[i,2];
            double avg=total/3.0;
            double percentage=(total/300.0)*100;

            result[i,0]=total;
            result[i,1]=Math.Round(avg,2);
            result[i,2]=Match.Round(percentage,2);
        }
        return result;
    }

    static void Display(int[,] scores,double[,] result,int student)
    {
        Console.WriteLine("Phy  Chem  Math  Total  Avg  \n");

        for(int i = 0; i < student; i++)
        {
            Console.WriteLine(scores[i,0]+"  " + scores[i,1] + "  " + scores[i,2] + "  " + result[i,0] + "  " + result[i,1] + "  " + result[i,2]);
        }
    }
}
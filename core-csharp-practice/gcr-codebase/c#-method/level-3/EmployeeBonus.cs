using System;

class EmployeeBonus
{
    static void Main(string[] args)
    {
        int[,] data=Data();
        double[,] results=Calculate(data);
        Display(data,results);
    }

    static int[,] Data()
    {
        Random r=new Random();
        int[,] data=new int[10,2];
        for(int i = 0; i < 10; i++)
        {
            data[i,0]=r.Next(10000,99999);
            data[i,1]=r.Next(1,15);
        }
        return data;
    }

    static double[,] Calculate(int[,] data)
    {
        double[,] results=new double[10,2];
        for(int i = 0; i < 10; i++)
        {
            double bonus=(data[i,1]>5)?0.05:0.02;
            results[i,0]=data[i,0]*bonus;
            results[i,1]=data[i,0]+results[i,0];
        }
        return results;
    }

    static void Display(int[,] data,double[,] results)
    {
        double totalOld=0;
        double totalNew=0;
        double totalBonus=0;

        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine(data[i,0]+"  " + data[i,1] + "  " + results[i,0] + "  " + results[i,1]);
            totalOld+=data[i,0];
            totalBonus+=results[i,0];
            totalNew+=results[i,1];
        }

        Console.WriteLine("Total Old Salary: " + totalOld);
        Console.WriteLine("Total New Salary: " + totalNew);
        Console.WriteLine("Total Bonus: " + totalBonus);

    }
}
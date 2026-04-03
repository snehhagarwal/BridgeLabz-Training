using System;

class BMI
{
    static void Main(string[] args)
    {
        double[,] data=new double[10,3]; //weight,height,bmi

        //taking input from the user
        for(int i = 0; i < 10; i++)
        {
            Console.Write("Enter the weight: ");
            data[i,0]=Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height: ");
            data[i,1]=Convert.ToDouble(Console.ReadLine());

            //bmi calculation
            data[i,2]=calculate(data[i,0],data[i,1]);

            //printing statement
            Console.WriteLine("BMI: " + data[i,2] + " Status: " + BMIstatus(data[i,2]));       
        }
    }

    static double calculate(double weight,double height)
    {
        double heightM=height/100; //cm to meter
        return weight/(heightM*heightM);
    }

    static string BMIstatus(double bmi)
    {
        if (bmi <= 18.4)
        {
            return "Underweight";
        }if(bmi>=18.5 && bmi <= 24.9)
        {
            return "Normal";
        }
        if(bmi>=25.0 && bmi <= 39.9)
        {
            return "Overweight";
        }
        return "Obese";
    }
}
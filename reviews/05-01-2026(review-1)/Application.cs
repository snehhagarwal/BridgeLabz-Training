using System;
using System.Linq.Expressions;
using Microsoft.VisualBasic.FileIO;
class Application
{
    public static void Main()
    {
        Fitness user = new Fitness()
        {
            /////
            fit.Step = 1800,
            fit.Calories = 800

        };
        if (user is Fitness)
        {
            Console.WriteLine("The user is a part of the fitness tracking application");
        }

        user.CalculateCal();
        user.BMI();

        user.Display();//cal burnt ,input cal//bmi)-abs enc get ser\


    }


}
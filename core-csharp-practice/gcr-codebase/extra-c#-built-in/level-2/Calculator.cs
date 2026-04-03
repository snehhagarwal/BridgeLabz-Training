using System;

class Calculator
{
    static void Main(string[] args)
    {
        //taking input from user
        Console.Write("Enter the first number: ");
        int a=Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b=Convert.ToDouble(Console.ReadLine());

        //giving user options
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.WriteLine("1. Choose operation: ");

        //user choosing choice
        int c=Convert.ToInt32(Console.ReadLine());

        if (c == 1)
        {
            Console.WriteLine("Results are: " + Add(a,b));
        }
        else if (c == 2)
        {
            Console.WriteLine("Results are: " + Subtract(a,b));
        }else if (c == 3)
        {
            Console.WriteLine("Results are: " + Multiply(a,b));
        }
        else if (c == 4)
        {
            Console.WriteLine("Results are: " + Divide(a,b));
        }

    }

    //for addition
    static double Add(double a,double b)
    {
        return a+b;
    }

    //for subtraction
    static double Subtract(double a,double b)
    {
        return a-b;
    }

    //for multiply
    static double Multiply(double a,double b)
    {
        return a*b;
    }

    //for divide
    static double Divide(double a,double b)
    {
        return a/b;
    }
}
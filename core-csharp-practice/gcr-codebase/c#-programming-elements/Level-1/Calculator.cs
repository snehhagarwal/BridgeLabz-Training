using System;

class Calculator{
    static void Main(){

        //first number
        Console.WriteLine("Enter the first number: ");
        double num1=Convert.ToDouble(Console.ReadLine());

        //second number
        Console.WriteLine("Enter the second number: ");
        double num2=Convert.ToDouble(Console.ReadLine());

        int sum=num1+num2;       //add
        int sub=num1-num2;       //subtraction
        int multiply=num1*num2;  //multiply
        int div=num1/num2;       //division
 
        Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers " + num1 + " and " + num2 + " is " + sum + ", " + sub + ", " + multiply + ", " + div);

    }
}
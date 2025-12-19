using System;

class QuotientRemainder{
    static void Main(){
        //taking input from user
        Console.WriteLine("Enter first number");
        int num1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number");
        int num2=Convert.ToInt32(Console.ReadLine());
        
        //calculating quotient
        int q=num1/num2;

        //calculating remainder
        int rem=num1%num2;

        Console.WriteLine("The Quotient is " + q + " and the Remainder is " + rem + " of two numbers " + num1 + " and " + num2);
    }
}
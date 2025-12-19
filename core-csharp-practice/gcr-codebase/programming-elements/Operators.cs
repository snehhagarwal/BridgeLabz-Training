using System;

class Operators{
    static void Main(string[] args){

        //Arithmetic Operators
        int num1=5;
        int num2=7;

        Console.WriteLine("The Arithmetic operators ");
        Console.WriteLine("The addition operation is: " + (num1+num2));
        Console.WriteLine("The subtraction operation is: " + (num2-num1));
        Console.WriteLine("The Multiplication operation is: " + (num1*num2));
        Console.WriteLine("The Division operation is: " + (num2/num1));

        //Comparison Operators
        Console.WriteLine("The comparison operators");
        Console.WriteLine("Not Equal To: " + (num1!=num2));
        Console.WriteLine("Equal To: " + (num1==num2));
        Console.WriteLine("Greater than: " + (num1 > num2));
        Console.WriteLine("Less than: " + (num1<num2));
        Console.WriteLine("Greater than or Equal to: " + (num1>=num2));
        Console.WriteLine("Less than or Equal to: " + (num1<=num2));

        //Logical Operators
        Console.WriteLine("The logical operators are: ");
        Console.WriteLine("AND Operator: " + (num1>0 && num2>0));
        Console.WriteLine("OR Operator: " + (num1>2 || num2 >3));
        Console.WriteLine("NOT Operator: " + !(num1>3));

        //Assignment Operator
        Console.WriteLine("The Assignment operators are");
        int num3=num1;
        Console.WriteLine("The assigned value is: " + num3);
        num3+=num2;
        Console.WriteLine("Addition Assignment is: " + num3);
        num3-=num1;
        Console.WriteLine("Subtraction Assignment is: " + num3);
        num3=num3*num2;
        Console.WriteLine("Multiplication Assignment is: " + num3);
        num3=num3/num1;
        Console.WriteLine("Division Assignment is: " + num3);
        num3=num3%num2;
        Console.Write("Modulus Assignment is: " + num3);

        //Increment and Decrement Operators
        Console.WriteLine("The Increment and Decrement Operators are");
        Console.WriteLine("The original value is: " + num2);
        Console.WriteLine("The post incremented value is: " + (num2++));
        Console.WriteLine("The pre incremented value is: " + (++num2));
        Console.WriteLine("The post decremented value is: " + (num2--));
        Console.WriteLine("The pre decremented value is: " + (--num2));

    }
}
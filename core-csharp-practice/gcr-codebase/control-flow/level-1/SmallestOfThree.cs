using System;

class SmallestOfThree{
    static void Main(string[] args){
        //taking three numbers as input from user
        Console.Write("Enter the first number: ");
        int num1=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3=Convert.ToInt32(Console.ReadLine());
        
        //condition to check whether the first number is smallest than the other two
        if(num1<num2 && num1<num3){
            Console.WriteLine("Is the first number the smallest? True");
        }else{
            Console.WriteLine("Is the first number the smallest? False");
        }

    }
}
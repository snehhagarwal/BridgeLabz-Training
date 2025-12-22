using System;

class LargestOfThree{
    static void Main(string[] args){

        //taking input from user
        Console.Write("Enter the first number: ");
        int num1=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3=Convert.ToInt32(Console.ReadLine());

        //to check which one is the largest among the three
        if(num1>num2 && num1>num3){
            Console.WriteLine("Is the first number the largest? Yes");
            Console.WriteLine("Is the second number the largest? No");
            Console.WriteLine("Is the third number the largest? No");
        }
        else if(num2>num1 && num2>num3){
            Console.WriteLine("Is the first number the largest? No");
            Console.WriteLine("Is the second number the largest? Yes");
            Console.WriteLine("Is the third number the largest? No");
        }
        else{
            Console.WriteLine("Is the first number the largest? No");
            Console.WriteLine("Is the second number the largest? No");
            Console.WriteLine("Is the third number the largest? Yes");
        }
    }
}
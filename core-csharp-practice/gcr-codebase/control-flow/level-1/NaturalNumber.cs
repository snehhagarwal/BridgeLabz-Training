using System;

class NaturalNumber{
    static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter the number: ");
        int num1=Convert.ToInt32(Console.ReadLine());

        //checking if the number is a natural number if yes then return sum of natural numbers
        if(num1>=0){
             int sum=n*(n+1)/2;
             Console.WriteLine("The sum of " + num1 + " natural number is " + sum);
        }else{
            Console.WriteLine("The number " + num1 + " is not a natural number.");
        }
    }
}
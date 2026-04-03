using System;

class FactorialFor{
    static void Main(string[] args){
        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //positive number
        if(num>=0){
            int factorial=1;
            for(int i=1;i<=num;i++){
                factorial*=i;
            }
        }
        Console.WriteLine("The factorial is " + factorial);
    }
}
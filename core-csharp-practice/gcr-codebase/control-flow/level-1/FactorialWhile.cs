using System;

class FactorialWhile{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //entered a positive number
        if(num>0){
            //factorial calculation 
            int factorial=1;
            int i=1;
            while(i<=num){
                 factorial*=i;
                 i++;
            }
        }
        Console.WriteLine("The factorial is " + factorial);
    }
}
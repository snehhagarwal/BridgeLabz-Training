using System;

class PositiveOrNegative{
    static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //condition to check positive,negativve or zero
        if(num==0){
            Console.WriteLine("The number is Zero");
        }
        else if(num>0){
            Console.WriteLine("The number is Positive");
        }
        else{
            Console.WriteLine("The number isNegative")
        }
    }
}
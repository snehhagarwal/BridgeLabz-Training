using System;

class FizzBuzzFor{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //code for fizzbuzz using for loop
        for(int i=1;i<=num;i++){
            if(i%3==0 && i%5==0){
                Console.WriteLine("FizzBuzz");
            }
            else if(i%3==0){
                Console.WriteLine("Fizz");
            }else if(i%5==0){
                Console.WriteLine("Buzz");
            }else{
                Console.WriteLine(i);
            }
        }
    }
}
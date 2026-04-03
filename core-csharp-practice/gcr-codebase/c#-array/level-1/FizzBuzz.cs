using System;

class FizzBuzz{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        string[] results=new string[number+1];

        //updating the array 
        for(int i=1;i<=number;i++){
            if(i%3==0 && i%5==0){
                results[i]="FizzBuzz";
            }
            else if(i%3==0){
                results[i]="Fizz";
            }else if(i%5==0){
                results[i]="Buzz";
            }else{
                results[i]=i.ToString();
            }
        }

        //printing the numbers
        for(int i=1;i<=number;i++){
            Console.WriteLine("Position " + i + " = " + results[i]);
        }
    }
}
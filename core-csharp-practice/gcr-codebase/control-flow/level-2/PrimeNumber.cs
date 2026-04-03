using System;

class PrimeNumber{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter a number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //flag variable
        bool isPrime=true;

        if(num<=1){
            isPrime=false;
        }
        else{
            for(int i=2;i<num;i++){
                if(num%i==0){
                    isPrime=false;
                    break;
                }
            }
        }

        //printing statement
        if(isPrime){
            Console.WriteLine("The number is a Prime Number.");
        }else{
            Console.WriteLine("The number is not a Prime Number.");
        }
    }
}
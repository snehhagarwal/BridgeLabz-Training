using System;

class AbundantNumber{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        int sum=0; //sum of divisors
        for(int i=1;i<num;i++){
            if(num%i==0){
                sum+=i;
            }
        }

        //if sum greater than number then abundant number
        if(sum>num){
            Console.WriteLine("The number is an Abundant Number.");
        }else{
            Console.WriteLine("The number is an Abundant Number.");
        }

    }
}
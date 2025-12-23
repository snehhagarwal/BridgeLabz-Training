using System;

class FactorsOfNumber{

    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        for(int i=1;i<num;i++){
            if(num%i==0){
                Console.WriteLine("The factor of number is: " + i);
            }
        }
    }
}
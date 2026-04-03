using System;

class PowerOfNumber{
    static void Main(string[] args){
        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power=Convert.ToInt32(Console.ReadLine());

        int answer=1;
        
        //loop for power
        for(int i=1;i<=power;i++){
            answer=answer*number;
        }

        Console.WriteLine("The number after power is: " + answer);
    }
}
using System;

class ArmstrongNumber{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //copy the num in another variable so that we can perform operations on that 
        int number=num;
        int sum=0;

        //checking whether it is armstrong number 
        while(number!=0){
            int lastDigit=number%10;
            sum+=lastDigit*lastDigit*lastDigit;
            number=number/10; //removing the last digit
        }

        //if sum is equal to number it is a armstrong number
        if(sum==num){
            Console.WriteLine("The number is an Armstrong number");
        }else{
            Console.WriteLine("The number is not an armstrong number");
        }
    }
}
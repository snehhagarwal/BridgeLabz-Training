using System;

class HarshadNumber{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //sum of the digits of number
        int sum=0;
        int number=num;
        while(number!=0){
            int lastDigit=number%10;
            sum+=lastDigit;
            number=number/10;
        }
        
        //if the sum divides the number then it is a harshad number
        if(num%sum==0){
            Console.WriteLine("The number " + num + " is a Harshad Number.");
        }else{
            Console.WriteLine("The number " + num + " is not a Harshad number.");
        }

    }
}
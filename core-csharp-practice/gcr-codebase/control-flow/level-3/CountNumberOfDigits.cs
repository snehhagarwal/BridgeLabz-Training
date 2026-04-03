using System;

class CountNumberOfDigits{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //code to count the number of digits
        int count=0;

        while(num!=0){
            num=num/10;   //removing the last digit
            count++;      //incrementing
        }

        Console.WriteLine("The number of digits the number has are: " + count);
    }
}
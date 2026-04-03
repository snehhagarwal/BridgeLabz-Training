using System;

class DigitFrequency{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int[] freq=new int[10];

        //frequency of each number
        while(number!=0){
             int digit=number%10;
             freq[digit]++;
             number=number/10;
        }

        //printing statement 
        for(int i=0;i<10;i++){
             Console.WriteLine("Digit " + i + " = " + freq[i]);
        }
    }
}
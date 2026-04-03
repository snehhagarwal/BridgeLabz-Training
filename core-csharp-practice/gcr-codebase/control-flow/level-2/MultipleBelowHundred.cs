using System;

class MultipleBelowHundred{
    static void Main(sring[] args){

        //take input from user
        Console.Write("Enter the number: ");
        int num=Convert.ToInt32(Console.ReadLine());

        //printing multiple below 100
        for(int i=100;i>=1;i--){
            if(i%number==0){
                Console.WriteLine("The multiple below 100 is " + i);
            }
        }
    }
}
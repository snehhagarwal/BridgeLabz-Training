using System;

class SumUntilZero{
    static void Main(string[] args){

        //Enter the number from user
        double total=0.0;
        double num;

        //summing until user enters zero
        while(true){
            num=Convert.ToDouble(Console.ReadLine());
            if(num==0){
                break;
            }
            total+=num;
        }

        Console.WriteLine("The total is: " + total);

    }
}
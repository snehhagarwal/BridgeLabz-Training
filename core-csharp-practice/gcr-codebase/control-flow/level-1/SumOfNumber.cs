using System;

class SumOfNumber{

    static void Main(string[] args){
    //taking input from the user
    double total=0.0;
    double num=Convert.ToDouble(Console.ReadLine());

    //summing until the user enters zero
    while(num!=0){
        total+=num;
        num=Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("The value of total is" + total);
    }
}
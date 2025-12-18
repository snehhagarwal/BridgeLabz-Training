using System;

class SimpleInterest{
    public static void Main(string[] args){

        Console.Write("Enter the principal amount: ");
        int principal=int.Parse(Console.ReadLine());

        Console.Write("Enter the rate: ");
        int rate=int.Parse(Console.ReadLine());

        Console.Write("Enter the time: ");
        int time=int.Parse(Console.ReadLine());

        //calculating the simple interest
        int si=(principal*rate*time)/100;

        //printing statement
        Console.Write("The Simple Interest is :" + si);
    }
}
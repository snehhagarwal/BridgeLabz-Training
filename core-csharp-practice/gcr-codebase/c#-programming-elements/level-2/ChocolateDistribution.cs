using System;

class ChocolateDistribution{
    static void Main(string[] args){
        //taking inputs from the user
        Console.WriteLine("Enter the no of chocolates: ");
        int chocolates=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the no of children: ");
        int children=Convert.ToInt32(Console.ReadLine());

        //number of chocolates each child gets
        int eachchild=chocolates/children;
        //remaining chocolates 
        int remain=chocolates%children;

        Console.WriteLine("The number of chocolates each child gets is " + eachchild + " and the number of remaining chocolates is " + remain);
        

    }
}
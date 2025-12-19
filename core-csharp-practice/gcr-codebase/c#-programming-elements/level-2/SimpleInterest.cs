using System;

class SimpleInterest{
    static void Main(string[] args){
        //taking input from the users
        Console.WriteLine("Enter the principal amount: ");
        double principal=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the rate: ");
        double rate=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the time: ");
        double time=Convert.ToDouble(Console.ReadLine());

        //calculating the interest 
        double interest=(principal*rate*time)/100;

        //printing statement
        Console.WriteLine("The Simple Interest is " + interest + " for Principal " + principal + ", Rate of Interest " + rate + " and Time " + time);
    }
}
using System;

class SimpleInterest{
    static void Main(string[] args){
        
        //taking input from the user
        Console.Write("Enter the principal: ");
        double principal=Convert.ToDouble(Console.Readline());

        Console.Write("Enter the rate: ");
        double rate=Convert.ToDouble(Console.Readline());

        Console.Write("Enter the time: ");
        double time=Convert.ToDouble(Console.Readline());

        //function call for calculation 
        double si=func(principal,rate,time);

        //printing statement 
        Console.WriteLine("The simple interest for principal " + principal + " ,rate " + rate+ " and time " + time +" is: " + si);
    }

    static double func(double p,double r, double t)
    {
        //formula 
        double ans=(p*r*t) /100;
        return ans;
    }
}
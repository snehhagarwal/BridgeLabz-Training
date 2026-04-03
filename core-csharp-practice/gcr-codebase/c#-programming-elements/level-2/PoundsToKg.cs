using System;

class PoundsToKg{
    static void Main(string[] args){
        //taking inputs from user
        Console.WriteLine("Enter weight in pounds");
        double pounds=Convert.ToDouble(Console.ReadLine());

        //conversion in kg
        double kg=pounds/2.2;

        //printing statement
        Console.WriteLine("The weight of the person in pounds is " + pounds + " and in kg is " + kg);
    }
}
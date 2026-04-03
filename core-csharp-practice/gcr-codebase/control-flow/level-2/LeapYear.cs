using System;

class LeapYear{
    static void Main(string[] args){
        //take year as the input
        Console.Write("Enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());

        if(year<1582){
            Console.WriteLine("Enter a valid year.");
        }
        else{
            if(year%400==0){
                Console.WriteLine("The year is a Leap Year.");
            }else if(year%100==0){
                Console.WriteLine("The year is a Leap Year.");
            }else if(year%4==0){
                Console.WriteLine("Year is a Leap Year.")
            }else{
                Console.WriteLine("Year is not a Leap Year.")
            }
        }
    }
}
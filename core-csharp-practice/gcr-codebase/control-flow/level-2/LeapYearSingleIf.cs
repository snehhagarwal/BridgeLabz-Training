using System;

class LeapYearSingleIf{
    static void Main(string[] args){

        //take input from the user
        Console.Write("Enter the year: ");
        int year=Convert.ToInt32(Console.ReadLine());

        if(year>=1582 && ((year%4==0 && year%100!=0) || year%400==0)){
            Console.ReadLine("Year is a Leap Year.");
        }else{
            Console.WriteLine("The year is not a Leap Year.");
        }
    }
}
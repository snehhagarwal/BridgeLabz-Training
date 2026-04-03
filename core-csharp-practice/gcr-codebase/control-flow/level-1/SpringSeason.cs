using System;

class SpringSeason{
    static void Main(string[] args){

        //taking input from the user
        Console.Write("Enter the month: ");
        int month=Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the day: ");
        int day=Convert.ToInt32(Console.ReadLine());

        //checking if the month and day is in spring season
        if(month==3 && day>=20 || month>3 && month<=6 || month==6 && day<=20){
            Console.WriteLine("Its a Spring Season");
        }
        else{
            Console.WriteLine("Not a Spring Season");
        }
    }
}
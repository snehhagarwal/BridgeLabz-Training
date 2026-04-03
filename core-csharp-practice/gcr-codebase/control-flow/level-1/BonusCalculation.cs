using System;

class BonusCalculation{
    static void Main(string[] args){
         
         //taking salary and year of service as input
         Console.Write("Enter the salary: ");
         double salary=Convert.ToDouble(Console.ReadLine());

         Console.Write("Enter the year of service: ");
         int years=Convert.ToInt32(Console.ReadLine());
 
         //year of service greater than 5
         if(years>5){
            double bonus=salary*0.05;
            Console.WriteLine("The bonus for the employee is: " + bonus);
         }else{
            Console.WriteLine("You are not eligible for bonus.");
         }
    }
}
using System;

class TotalIncome{
    static void Main(string[] args){
        //taking salary from user
        Console.WriteLine("Enter salary: ");
        double salary=Convert.ToDouble(Console.ReadLine());

        //taking bonus from user
        Console.WriteLine("Enter the bonus: ");
        double bonus=Convert.ToDouble(Console.ReadLine());
 
        //calculating total income
        double income=salary+bonus;

        //printing statement
        Console.WriteLine("The salary is INR "+ salary + " and bonus is INR " + bonus + ". Hence Total Income is INR " + income);
        
    }
}
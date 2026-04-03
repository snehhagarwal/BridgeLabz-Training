using System;

class FeeDiscountInput{
    static void Main(){
        //input from user
        Console.WriteLine("Ener the fee: ");
        double fee=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the discount percentage: ");
        double discountperc=Convert.ToDouble(Console.ReadLine());
        
        //dicount calculation
        double discount=(fee*discountperc)/100;
        //final to be paid
        double final=fee - discount;

        Console.WriteLine("The discount amount is INR " + discount + " and the final discounted fee is INR " + final);

    }
}
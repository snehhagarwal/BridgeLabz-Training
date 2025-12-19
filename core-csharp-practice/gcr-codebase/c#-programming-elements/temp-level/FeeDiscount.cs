using System;

class FeeDiscount{
    static void Main(){
        // fee to be paid
        double fee= 125000;

        //discount percentage
        double discountperc=10;

        //calculate discount
        double discount = (fee*discountperc)/100;

        //final fee to be paid
        double final=fee-discount;

        Console.WriteLine("The discount amount is INR " + discount + " and the final discounted fee is INR " + final);
    }
}
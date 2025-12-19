using System;

class PurchasePrice{
    static void Main(){
        //taking input from user
        Console.WriteLine("Enter unit price: ");
        double unit=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter quantity: ");
        double quantity=Convert.ToInt32(Console.ReadLine());

        //total price calculation
        double total=unit*quantity;

        Console.WriteLine("The total purchase price is INR " + total + " if the quantity " + quantity + " and unit price is INR " + unit);

    }
}
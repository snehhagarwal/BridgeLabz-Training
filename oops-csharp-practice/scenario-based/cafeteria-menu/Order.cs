using System;
using System.ComponentModel.Design;

class Order
{
    private double totalBill=0;
    public void PlaceOrder(Menu menu,int idx)
    {
        if (!menu.IsAvailable(idx))
        {
            Console.WriteLine("Sorry,the item is not available");
            return;
        }
        else
        {
            Console.Write("Enter quantity: ");
            int quantity=Convert.ToInt32(Console.ReadLine());

            if (quantity <= 0)
            {
                Console.WriteLine("Quantity must be greater than zero");
            }
            else
            {
                string item=menu.GetItemByIndex(idx);
                double price=menu.GetPrice(idx);

                double orderAmount=price*quantity;
                totalBill=totalBill+orderAmount;

                Console.WriteLine("Order Added");
                Console.WriteLine("Item: " + item);
                Console.WriteLine("Price: " + price);
                Console.WriteLine("Quantity: " + quantity);
                Console.WriteLine("Amount: Rs. " + orderAmount);
                Console.WriteLine("Current Total Bill: Rs. " + totalBill);

                menu.MarkUnavailable(idx);
            }
        }  
    }

    public void FinalBill()
    {
        Console.WriteLine("Final Bill Amount");
        Console.WriteLine("Total Payable: " + totalBill);
    }

}
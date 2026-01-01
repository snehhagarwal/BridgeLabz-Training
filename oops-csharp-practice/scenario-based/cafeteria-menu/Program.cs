using System;

class Program
{
    static void Main(string[] args)
    {
        string[] items={"Coffee","Tea","Arrabiata Pasta","Pink Sauce Pasta","Sandwich","Dumplings","Pizza","Burger","Hakka Noodles","Brownie"};
        double[] prices={20,10,100,120,50,60,100,40,70,100};

        Menu menu=new Menu(items,prices);

        Order order=new Order();

        Console.WriteLine("Welcome to the Cafe");
        bool continueOrdering=true;

        while (continueOrdering)
        {
            Console.WriteLine("\nMenu:");
            menu.Display();
            Console.Write("\nEnter the item number to place the order(or 0 to exit): ");
            int choice=Convert.ToInt32(Console.ReadLine());

                if (choice == 0)
                {
                    continueOrdering=false;
                    order.FinalBill();
                    Console.WriteLine("Thank you for visiting");
                }
                else
                {
                    order.PlaceOrder(menu,choice-1);
                }
        }
    }
}
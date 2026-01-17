using System;

class FlashMenu
{
    private IFlashDealz service;

    public FlashMenu(IFlashDealz service)
    {
        this.service=service;
    }

    public void ShowMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("Flash Deal Menu");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Sort Product by Discount");
            Console.WriteLine("3. Display Products");
            Console.WriteLine("4. Exit");

            Console.Write("Enter Choice: ");

            choice=Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    service.AddProduct();
                    break;
                case 2:
                    service.SortProducts();
                    break;
                case 3:
                    service.DisplayProducts();
                    break;
                case 4:
                    Console.WriteLine("Exit program");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }while(choice!=4);
    }
}
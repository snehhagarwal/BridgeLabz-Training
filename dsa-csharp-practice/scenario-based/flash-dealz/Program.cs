using System;

class Program
{
    static void Main(string[] args)
    {
        IFlashDealz utility=new FlashUtility();
        FlashMenu menu=new FlashMenu(utility);
        menu.ShowMenu();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        IFlashDealz utility=new FlashUtility(); // utility object
        FlashMenu menu=new FlashMenu(utility);   // menu object
        menu.ShowMenu();    // start program
    }
}
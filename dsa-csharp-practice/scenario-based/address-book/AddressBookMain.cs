using System;

class AddressBookMain
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Address Book Program");

        Menu menu=new Menu();
        menu.Start();

        Console.ReadLine();
    }
}

using System;

class AddressBookMain{
    public static void Main(string[] args){
        AddressBookMenu menu = new AddressBookMenu();
        menu.Start();   // only method call

        Console.ReadLine();
    }
}

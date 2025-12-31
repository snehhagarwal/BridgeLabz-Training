using System;

class Program
{
    static void Main()
    {
        // Database size 10
        BankAccount db = new BankAccount(10);

        // Start user 
        User ui = new User(db);
        ui.Start();
    }
}

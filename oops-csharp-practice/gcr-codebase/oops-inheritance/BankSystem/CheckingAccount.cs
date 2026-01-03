using System;

public class CheckingAccount : BankAccount
{
    public double Withdraw;

    public void Display()
    {
        Console.WriteLine("Account Type: Checking Account");
        Console.WriteLine("Withdraw Limit: " + Withdraw);
    }
}
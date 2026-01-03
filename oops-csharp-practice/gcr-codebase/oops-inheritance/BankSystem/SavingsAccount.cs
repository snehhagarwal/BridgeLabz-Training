using System;

public class SavingsAccount : BankAccount
{
    public double rate;

    public void Display()
    {
        Console.WriteLine("Account Type: Savings Account");
        Console.WriteLine("Interest Rate: " + rate);
    }
}
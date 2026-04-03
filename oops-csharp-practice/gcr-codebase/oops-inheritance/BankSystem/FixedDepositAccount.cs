using System;

public class FixedDepositAccount : BankAccount
{
    public int Tenure;
    public void Display()
    {
        Console.WriteLine("Account Type: Fixed Deposit Account");
        Console.WriteLine("Tenure(yr): " + Tenure);
    }
}
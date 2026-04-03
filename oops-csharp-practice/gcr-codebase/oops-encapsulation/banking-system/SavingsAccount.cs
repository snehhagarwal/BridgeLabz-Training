using System;

public class SavingsAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return Balance*0.04;
    }
}
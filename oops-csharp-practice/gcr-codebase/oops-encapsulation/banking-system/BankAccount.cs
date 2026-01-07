using System;

public abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    private double balance;

    public int AccountNumber{get=>accountNumber;set=>accountNumber=value;}
    public string HolderName{get=>holderName;set=>holderName=value;}
    public double Balance{get=>balance;set=>balance=value;}

    public void Deposit(double amt)
    {
        Balance+=amt;
    }

    public void WithDraw(double amt)
    {
        Balance-=amt;
    }

    public abstract double CalculateInterest();
}
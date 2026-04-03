using System;

public class BankAccount
{
    // Fields
    public int AccountNumber;
    public string Name;
    private string Password;
    private double Balance;

    // Constructor
    public BankAccount(int acc, string name, string password, double balance)
    {
        AccountNumber = acc;
        Name = name;
        Password = password;
        Balance = balance;
    }

    // Verify password
    public bool VerifyPassword(string pin)
    {
        return Password == pin;
    }

    // Deposit
    public void Deposit(double amnt)
    {
        if (amnt > 0)
        {
            Balance += amnt;
            Console.WriteLine("Amount deposited: " + amnt);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount!");
        }
    }

    // Withdraw
    public void Withdraw(double cost)
    {
        if (cost <= Balance && cost > 0)
        {
            Balance -= cost;
            Console.WriteLine("Amount withdrawn: " + cost);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }

    // Check balance
    public void CheckBalance()
    {
        Console.WriteLine("Current balance: " + Balance);
    }

    // Show account info
    public void ShowAccountInfo()
    {
        Console.WriteLine("Account Number: " + AccountNumber);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Balance: " + Balance);
    }
}

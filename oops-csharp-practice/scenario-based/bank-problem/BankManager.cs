using System;

public class BankManager
{
    public BankAccount[] accounts;
    public int count;
    private int nextAccount;

    public BankManager(int n)
    {
        accounts = new BankAccount[n];
        count = 0;
        nextAccount = 1001; // Start account numbers from 1001
    }

    // Add account
    public BankAccount AddAccount(string name, string password, double balance)
    {
        if (count < accounts.Length)
        {
            BankAccount newAccount = new BankAccount(
                nextAccount,
                name,
                password,
                balance
            );
            accounts[count] = newAccount;
            count++;
            nextAccount++;
            return newAccount;
        }
        else
        {
            Console.WriteLine("Database full! Cannot add more accounts.");
            return null;
        }
    }

    // Find account by account number
    public BankAccount FindAccount(int accNum)
    {
        for (int i = 0; i < count; i++)
        {
            if (accounts[i].AccountNumber == accNum)
            {
                return accounts[i];
            }
        }
        return null;
    }
}

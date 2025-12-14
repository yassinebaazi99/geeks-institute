using System;
using System.Collections.Generic;

public class Account
{
    public string AccountNumber { get; set; }
    public int PIN { get; set; }
    public double Balance { get; set; }
    public List<string> Transactions { get; set; }

    public Account(string accountNumber, int pin, double initialBalance)
    {
        AccountNumber = accountNumber;
        PIN = pin;
        Balance = initialBalance;
        Transactions = new List<string>();
        Transactions.Add($"Initial Balance: ${initialBalance}");
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance: ${Balance}");
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            string transaction = $"Deposit: ${amount}";
            Transactions.Add(transaction);
            Console.WriteLine($"Deposit successful! New balance: ${Balance}");
        }
        else
        {
            Console.WriteLine("Invalid deposit amount. Must be positive.");
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                string transaction = $"Withdraw: ${amount}";
                Transactions.Add(transaction);
                Console.WriteLine($"Withdrawal successful! New balance: ${Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount. Must be positive.");
        }
    }

    public void ShowTransactions()
    {
        Console.WriteLine("\nTransaction History:");
        foreach (string transaction in Transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}

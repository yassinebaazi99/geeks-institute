using System;
using System.Collections.Generic;

public class ATM
{
    private Dictionary<string, Account> accounts;

    public ATM()
    {
        accounts = new Dictionary<string, Account>();
    }

    public void AddAccount(Account account)
    {
        accounts[account.AccountNumber] = account;
    }

    public Account Authenticate()
    {
        Console.Write("Please enter your account number: ");
        string accountNumber = Console.ReadLine();

        if (!accounts.ContainsKey(accountNumber))
        {
            Console.WriteLine("Account not found.");
            return null;
        }

        Console.Write("Enter your PIN: ");
        int pin;
        if (!int.TryParse(Console.ReadLine(), out pin))
        {
            Console.WriteLine("Invalid PIN format.");
            return null;
        }

        Account account = accounts[accountNumber];
        if (account.PIN == pin)
        {
            Console.WriteLine("Authentication successful!\n");
            return account;
        }
        else
        {
            Console.WriteLine("Invalid PIN.");
            return null;
        }
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nATM Menu:");
        Console.WriteLine("1. Check Balance");
        Console.WriteLine("2. Deposit Money");
        Console.WriteLine("3. Withdraw Money");
        Console.WriteLine("4. Show Transactions");
        Console.WriteLine("5. Exit");
        Console.Write("\nSelect an option: ");
    }

    public void PerformAction(Account account, string choice)
    {
        switch (choice)
        {
            case "1":
                account.CheckBalance();
                break;
            case "2":
                Console.Write("Enter deposit amount: ");
                double depositAmount;
                if (double.TryParse(Console.ReadLine(), out depositAmount))
                {
                    account.Deposit(depositAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;
            case "3":
                Console.Write("Enter withdrawal amount: ");
                double withdrawAmount;
                if (double.TryParse(Console.ReadLine(), out withdrawAmount))
                {
                    account.Withdraw(withdrawAmount);
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;
            case "4":
                account.ShowTransactions();
                break;
            case "5":
                Console.WriteLine("\nThank you for using our ATM. Here's a summary of your transactions:");
                account.ShowTransactions();
                break;
            default:
                Console.WriteLine("Invalid option. Please try again.");
                break;
        }
    }
}
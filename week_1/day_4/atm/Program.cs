using System;

class Program
{
    static void Main(string[] args)
    {
        ATM atm = new ATM();

        Account account1 = new Account("12345", 6789, 1000);
        Account account2 = new Account("54321", 1234, 2500);
        Account account3 = new Account("99999", 5555, 500);

        atm.AddAccount(account1);
        atm.AddAccount(account2);
        atm.AddAccount(account3);

        Console.WriteLine("Welcome to the ATM Machine!");

        Account currentAccount = atm.Authenticate();

        if (currentAccount != null)
        {
            bool running = true;
            while (running)
            {
                atm.ShowMenu();
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    atm.PerformAction(currentAccount, choice);
                    running = false;
                }
                else
                {
                    atm.PerformAction(currentAccount, choice);
                }
            }
        }
        else
        {
            Console.WriteLine("Authentication failed. Exiting...");
        }
    }
}

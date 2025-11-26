using System;

class Program
{
    static void Main(string[] args)
    {
        BankAccount acc = new BankAccount("ACC123", 1000);

        Console.WriteLine("Account Number: " + acc.AccountNumber);

        acc.Deposit(500);
        acc.Withdraw(300);

        Console.WriteLine("Remaining Balance: " + acc.Balance);
    }
}

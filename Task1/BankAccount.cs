public class BankAccount
{
    private string accountNumber;
    private double balance;

    public string AccountNumber  // only get
    {
        get { return accountNumber; }
    }

    public double Balance       // set private
    {
        get { return balance; }
        private set
        {
            if (value > 0)
                balance = value;
        }
    }

    public BankAccount(string accNo, double initialBalance)
    {
        accountNumber = accNo;

        if (initialBalance > 0)
            balance = initialBalance;
        else
            balance = 0;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance = balance + amount;
        }
    }

    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= balance)
        {
            Balance = balance - amount;
        }
    }
}

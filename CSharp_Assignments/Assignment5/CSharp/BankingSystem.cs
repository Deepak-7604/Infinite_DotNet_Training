using System;

// Custom Exception Class
public class InsufficientBalanceException : Exception
{
    public InsufficientBalanceException()
        : base("Insufficient balance in the account.") { }

    public InsufficientBalanceException(string message)
        : base(message) { }
}

// Bank Account Class
public class BankAccount
{
    private double balance;

    public BankAccount(double initialBalance)
    {
        if (initialBalance < 0)
            throw new ArgumentException("Initial balance cannot be negative.");

        balance = initialBalance;
    }

    // Deposit Method
    public void Deposit(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");

        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    // Withdraw Method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > balance)
            throw new InsufficientBalanceException("Not enough balance to withdraw.");

        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
    }

    // Check Balance
    public void CheckBalance()
    {
        Console.WriteLine($"Current Balance: {balance}");
    }
}

// Main Program
class BankingSystem
{
    static void Main()
    {
        try
        {
            BankAccount account = new BankAccount(5000);

            account.Deposit(1000);
            account.CheckBalance();

            account.Withdraw(2000);
            account.CheckBalance();

            // This will throw exception
            account.Withdraw(10000);
        }
        catch (InsufficientBalanceException ex)
        {
            Console.WriteLine("Custom Exception: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Argument Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("General Exception: " + ex.Message);
        }
    }
}
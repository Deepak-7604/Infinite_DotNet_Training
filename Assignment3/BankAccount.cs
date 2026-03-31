using System;

namespace Assignment3
{
    class Accounts
    {
       
        int accountNo;
        string customerName;
        string accountType;
        char transactionType;
        double amount;
        double balance;

      
        public Accounts(int accNo, string custName, string accType, double bal)
        {
            accountNo = accNo;
            customerName = custName;
            accountType = accType;
            balance = bal;
        }

        
        public void Credit(double amt)
        {
            balance += amt;
            Console.WriteLine("Deposited: " + amt);
        }

       
        public void Debit(double amt)
        {
            if (amt <= balance)
            {
                balance -= amt;
                Console.WriteLine("Withdrawn: " + amt);
            }
            else
            {
                Console.WriteLine("Insufficient balance!");
            }
        }

        // Update transaction
        public void UpdateTransaction(char tType, double amt)
        {
            transactionType = tType;
            amount = amt;

            if (transactionType == 'D' || transactionType == 'd')
            {
                Credit(amount);
            }
            else if (transactionType == 'W' || transactionType == 'w')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type!");
            }
        }

        // Display details
        public void ShowData()
        {
            Console.WriteLine("\n--- Account Details ---");
            Console.WriteLine("Account No: " + accountNo);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction Type: " + transactionType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Balance: " + balance);
        }
    }

    internal class BankAccount
    {
        static void Main(string[] args)
        {
           
            Accounts acc = new Accounts(101, "Deepak", "Savings", 5000);

            
            acc.UpdateTransaction('D', 2000); 
            acc.UpdateTransaction('W', 1500); 

           
            acc.ShowData();

            Console.ReadLine();
        }
    }
}
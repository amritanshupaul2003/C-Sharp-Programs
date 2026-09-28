using System;

namespace OOPsLearning
{
    class BankAccount
    {
        // private field = hidden data
        private double balance;

        public BankAccount(double startingBalance)
        {
            balance = startingBalance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine("Deposited: " + amount);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Withdrawn: " + amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        public double GetBalance()
        {
            return balance;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000);

            account.Deposit(500);
            account.Withdraw(200);

            Console.WriteLine("Current Balance: " + account.GetBalance());
        }
    }
}

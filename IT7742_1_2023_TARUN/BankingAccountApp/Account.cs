using System.Globalization;

namespace BankingAccountApp
{
    public abstract class Account
    {
        private int accountID;
        private decimal balance;
        private decimal interestRate;
        private decimal overdraftLimit;
        private decimal failedFee;
        private string lastMessage;

        protected Account(int id, decimal opening, decimal rate, decimal overdraft, decimal fee)
        {
            accountID = id;
            balance = opening;
            interestRate = rate;
            overdraftLimit = overdraft;
            failedFee = fee;
            lastMessage = "";
        }

        public int GetAccountID() => accountID;
        public decimal GetBalance() => balance;

        // Compatible getter for any version of form or console
        public string Last() => lastMessage;
        public string GetLastMessage() => lastMessage;

        // Allow calling either Rate() or Rate
        protected decimal Rate() => interestRate;
        protected decimal RateValue => interestRate;

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                lastMessage = "Deposit ignored.";
                return;
            }
            balance += amount;
            lastMessage = $"Deposited {amount:0.00}; Balance: {balance:0.00}";
        }

        public virtual void Withdraw(decimal amount, bool staff)
        {
            if (amount <= 0)
            {
                lastMessage = "Invalid withdrawal.";
                return;
            }

            if (balance + overdraftLimit < amount)
            {
                decimal fee = staff ? failedFee / 2 : failedFee;
                balance -= fee;
                lastMessage = $"Failed withdrawal; Fee {fee:0.00}; Balance {balance:0.00}";
                return;
            }

            balance -= amount;
            lastMessage = $"Withdrawn {amount:0.00}; Balance {balance:0.00}";
        }

        protected void AddInterest(decimal val)
        {
            balance += val;
            lastMessage = $"Interest added {val:0.00}; Balance: {balance:0.00}";
        }

        public abstract void CalculateInterest();
    }
}

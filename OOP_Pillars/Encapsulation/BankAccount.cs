namespace Encapsulation
{
    internal class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            this.balance = initialBalance;
        }

        public double GetBalance()
        {
            return balance;
        }

        public string Withdraw(double amount)
        {
            if (this.balance < amount)
            {
                return $"You have insufficient funds! Current balance is {this.balance} EUR.";
            }

            this.balance -= amount;

            return $"You have withdrawn {amount} EUR.";
        }

        public string Deposit(double amount)
        {
            this.balance += amount;

            return $"You have added {amount} EUR.";
        }
    }
}
using System.Globalization;

namespace Exercise
{
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountOwner { get; set; }
        public double Balance { get; private set; }
        public double Tax = 5.00;

        public BankAccount(int accountNumber, string accountOwner)
        {
            AccountNumber = accountNumber;
            AccountOwner = accountOwner;
        }
        public BankAccount(int accountNumber, string accountOwner, double inicialAmount) : this(accountNumber, accountOwner)
        {
            AddBalance(inicialAmount);
        }

        public double AddBalance(double amount)
        {
            return Balance += amount;
        }

        public double RemoveBalance(double amount)
        {
            return Balance -= (amount + Tax);
        }

        public override string ToString()
        {
            return "Conta: "
            + AccountNumber
            + ", Titular: "
            + AccountOwner
            + ", Saldo: R$ "
            + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
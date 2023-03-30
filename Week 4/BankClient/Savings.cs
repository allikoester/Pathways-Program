namespace BankClient
{
    class Savings : Account, ICalculateInterest
    {

        public double AnnualInterestRate { get; set; }

        public Savings(int accountId, string accountType, double accountBalance, double annualInterestRate)
        : base(accountId, accountType, accountBalance)
        {
            AnnualInterestRate = annualInterestRate;
        }

        public override string ToString()
        {
            return base.ToString() + ", the annual interest rate is: " + AnnualInterestRate + " percent, and the annual interest earned is: $" + CalculateInterest();
        }

        public override void Withdrawal(int accountID, double withdrawalAmount)
        {
            if (AccountBalance > withdrawalAmount)
            {
                double updatedAccountBalance = AccountBalance - withdrawalAmount;
                AccountBalance = updatedAccountBalance;
                Console.WriteLine("Withdrawal made. New account balance is: " + AccountBalance);
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal cannot be made. ");
            }
        }

        public double CalculateInterest()
        {
            double Interestearned = AccountBalance * (AnnualInterestRate / 100);
            double RoundedInterestEarned = Math.Round(Interestearned, 2);
            return RoundedInterestEarned;
        }

    } // end class
} // end namespace
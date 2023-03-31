namespace Banking
{
    class CD : Account, ICalculateInterest
    {

        public double AnnualInterestRate { get; set; }

        public double Penalty { get; set; }

        public CD(int accountId, string accountType, double accountBalance, double annualInterestRate)
        : base(accountId, accountType, accountBalance)
        {
            AnnualInterestRate = annualInterestRate;
            Penalty = (((annualInterestRate / 100) / 365) * 90) * accountBalance;
        }

        public override string ToString()
        {
            return base.ToString() + ", the annual interest rate is: " + AnnualInterestRate + " percent, and the annual interest earned is: $" + CalculateInterest();
        }

        public override void Withdrawal(int accountID, double withdrawalAmount)
        {
            if (AccountBalance > (withdrawalAmount + Penalty))
            {
                double updatedAccountBalance = AccountBalance - withdrawalAmount - Penalty;
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

        public override void WriteToFile(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(AccountID);
            streamWriter.WriteLine(AccountType);
            streamWriter.WriteLine(AccountBalance);
            streamWriter.WriteLine(AnnualInterestRate);
        }

    } // end class
} // end namespace
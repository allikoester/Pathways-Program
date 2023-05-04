namespace BankClient
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
            String newString = String.Format(base.ToString() + ", the annual interest rate is: {0:F2} percent, and the annual interest earned is: ${1:F2}", AnnualInterestRate, CalculateInterest());
            //return base.ToString() + ", the annual interest rate is: " + AnnualInterestRate + " percent, and the annual interest earned is: $" + CalculateInterest();
            return newString;
        }

        public override void Withdrawal(int accountID, double withdrawalAmount)
        {
            if (AccountBalance > (withdrawalAmount + Penalty))
            {
                double updatedAccountBalance = AccountBalance - withdrawalAmount - Penalty;
                AccountBalance = updatedAccountBalance;

                // String outputString = String.Format("Withdrawal made. New account balance is: {0:F2}", AccountBalance);
                Console.WriteLine("Withdrawal made. New account balance is: " + Math.Round(AccountBalance, 2));
                // Console.WriteLine(outputString);
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
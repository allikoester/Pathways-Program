namespace Banking
{
    class Checking : Account
    {

        public double AnnualFee { get; set; }

        public Checking(int accountId, string accountType, double accountBalance, double annualfee)
        : base(accountId, accountType, accountBalance)
        {
            AnnualFee = annualfee;
        }

        public override string ToString()
        {
            return base.ToString() + ", the annual fee is: $" + AnnualFee;
        }

        public override void Withdrawal(int accountID, double withdrawalAmount)
        {
            if (withdrawalAmount <= (AccountBalance / 2))
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

        public override void WriteToFile(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(AccountID);
            streamWriter.WriteLine(AccountType);
            streamWriter.WriteLine(AccountBalance);
            streamWriter.WriteLine(AnnualFee);
        }

    } // end class
} // end namespace
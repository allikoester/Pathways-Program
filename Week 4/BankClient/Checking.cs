namespace BankClient
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
            return base.ToString() + ", the annual fee is: $" + Math.Round(AnnualFee, 2);
        }

        public override void Withdrawal(int accountID, double withdrawalAmount)
        {
            if (withdrawalAmount <= (AccountBalance / 2))
            {
                double updatedAccountBalance = AccountBalance - withdrawalAmount;
                AccountBalance = updatedAccountBalance;
                Console.WriteLine("Withdrawal made. New account balance is: " + Math.Round(AccountBalance, 2));
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal cannot be made. ");
            }
        }

    } // end class
} // end namespace
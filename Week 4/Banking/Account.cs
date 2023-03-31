namespace Banking
{
    abstract class Account
    {

        public int AccountID { get; set; }

        public string AccountType { get; set; }

        public double AccountBalance { get; set; }

        public Account()
        {
            AccountID = 0;
            AccountType = " ";
            AccountBalance = 0;
        }

        public Account(int accountId, string accountType, double accountBalance)
        {
            AccountID = accountId;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }

        public virtual string ToString()
        {
            return "The accound ID is: " + AccountID + ", the account type is: " + AccountType + ", the balance is: $" + AccountBalance;
        }

        public void Deposit(int accountID, double depositAmount)
        {
            double updatedAccountBalance = AccountBalance + depositAmount;
            AccountBalance = updatedAccountBalance;
            Console.WriteLine("Deposit has been made. New account balace is: " + AccountBalance);
        } // end Deposit method

        public virtual void Withdrawal(int accountID, double withdrawalAmount)
        {
        }

        public virtual void WriteToFile(StreamWriter streamWriter)
        {
        }

    } // end class
} // end namespace
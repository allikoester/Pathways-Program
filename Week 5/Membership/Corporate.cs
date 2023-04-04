namespace Membership
{
    class Corporate : Membership
    {

        public double CashBackPercent { get; set; }

        public double CashBack { get; set; }

        public Corporate(double cashBackPercent, int memberID, string memberEmail, string membershipType, double annualCost, double amountPurchased)
                : base(memberID, memberEmail, membershipType, annualCost, amountPurchased)
        {
            CashBackPercent = cashBackPercent;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override void ApplyCashBack(int memberID)
        {
            CashBack = AmountPurchased * (CashBackPercent / 100);
            Console.WriteLine("Press 'Y' to redeem $" + Math.Round(CashBack, 2) + " cash back. ");
            string userInput = Console.ReadLine();
            if ((userInput == "Y") || (userInput == "y"))
            {
                Console.WriteLine("Cash back reward request for membership " + memberID + " in the amount of $" + Math.Round(CashBack, 2) + " has been made. ");
                CashBack = 0;
            }
        }
    } // end class
} // end namespace
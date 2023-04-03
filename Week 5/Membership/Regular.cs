namespace Membership
{
    class Regular : Membership, ISpecialOffer
    {
        public double CashBackPercent { get; set; }

        public double CashBack { get; set; }

        public Regular(double cashBackPercent, int memberID, string memberEmail, string membershipType, double annualCost, double amountPurchased)
        : base(memberID, memberEmail, membershipType, annualCost, amountPurchased)
        {
            CashBackPercent = cashBackPercent;
        }

        public override string ToString()
        {
            return base.ToString()
            + ", and there is currently a special offer on renewed memberships for a return of $" + SpecialOffer();
        }

        public override void ApplyCashBack(int memberID)
        {
            CashBack = AmountPurchased * (CashBackPercent / 100);
            Console.WriteLine("Cash back reward request for membership " + memberID + " in the amount of $" + CashBack + " has been made. ");
            CashBack = 0;
        }

        public double SpecialOffer()
        {
            double SpecialOffer = AnnualCost * 0.25;
            return SpecialOffer;
        }



    } // end class
} // end namespace
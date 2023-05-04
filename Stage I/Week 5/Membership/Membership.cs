namespace Membership
{
    abstract class Membership
    {

        public int MemberID { get; set; }

        public string MemberEmail { get; set; }

        public string MembershipType { get; set; }

        public double AnnualCost { get; set; }

        public double AmountPurchased { get; set; }

        public double CashBackPercent { get; set; }

        public Membership()
        {
            MemberID = 0;
            MemberEmail = " ";
            MembershipType = " ";
            AnnualCost = 0;
            AmountPurchased = 0;
        }

        public Membership(int memberID, string memberEmail, string membershipType, double annualCost, double amountPurchased)
        {
            MemberID = memberID;
            MemberEmail = memberEmail;
            MembershipType = membershipType;
            AnnualCost = annualCost;
            AmountPurchased = amountPurchased;
        }


        public override string ToString()
        {
            return "The member ID is: " + MemberID
            + ", the contact email is: " + MemberEmail
            + ", the membership type is: " + MembershipType
            + ", the annual cost is: $" + AnnualCost
            + ", the current amount purchased is: $" + Math.Round(AmountPurchased, 2);
        }

        public void Purchase(int memberID, double purchaseAmount)
        {
            double updatedAmountPurchased = purchaseAmount + AmountPurchased;
            AmountPurchased = updatedAmountPurchased;
            Console.WriteLine("Purchase has been made. Total amount purchased is: $" + Math.Round(AmountPurchased, 2));
        }

        public void Return(int memberID, double returnAmount)
        {
            if (returnAmount <= AmountPurchased)
            {
                double updatedAmountPurchased = AmountPurchased - returnAmount;
                AmountPurchased = updatedAmountPurchased;
                Console.WriteLine("Return has been made. Total amount purchased is: $" + Math.Round(AmountPurchased, 2));
            }
            else
            {
                Console.WriteLine("Return amount is greater than the amount purchased. ");
            }
        }

        public abstract void ApplyCashBack(int memberID);

    } // end class
} // end namespace 
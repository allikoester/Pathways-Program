namespace Membership
{
    class NonProfit : Membership
    {

        public double CashBackPercent { get; set; }

        public double CashBack { get; set; }

        public NonProfit(double cashBackPercent, int memberID, string memberEmail, string membershipType, double annualCost, double amountPurchased)
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
            string userInput;
            do
            {
                Console.WriteLine("Please enter 'Y' if military or education affilitation. Enter 'N' if not. ");
                userInput = Console.ReadLine();
                if ((string.IsNullOrEmpty(userInput)) || ((userInput != "Y") && (userInput != "y") && (userInput != "N") && (userInput != "n")))
                {
                    Console.WriteLine("Please enter valid input. ");
                }

                else if ((userInput == "Y") || (userInput == "y"))
                {
                    CashBack = AmountPurchased * ((CashBackPercent * 2) / 100);
                    Console.WriteLine("Press 'Y' to redeem $" + CashBack + " cash back. ");
                    string input = Console.ReadLine();
                    if ((input == "Y") || (input == "y"))
                    {
                        Console.WriteLine("Cash back reward request for membership " + memberID + " in the amount of $" + Math.Round(CashBack, 2) + " has been made. ");
                        AmountPurchased = 0;
                    }
                }
                else if ((userInput == "N") || (userInput == "n"))
                {
                    CashBack = AmountPurchased * (CashBackPercent / 100);
                    Console.WriteLine("Press 'Y' to redeem $" + Math.Round(CashBack, 2) + " cash back. ");
                    string input = Console.ReadLine();
                    if ((input == "Y") || (input == "y"))
                    {
                        Console.WriteLine("Cash back reward request for membership " + memberID + " in the amount of $" + Math.Round(CashBack, 2) + " has been made. ");
                        AmountPurchased = 0;
                    }
                }
            }
            while ((string.IsNullOrEmpty(userInput)) || ((userInput != "Y") && (userInput != "y") && (userInput != "N") && (userInput != "n")));
        }

    } // end class
} // end namespace
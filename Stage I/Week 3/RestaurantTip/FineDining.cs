namespace RestaurantApp
{
    class FineDining : Restaurant
    {

        public FineDining(string newName, int newRating) : base(newName, newRating)
        { }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalculateTip(double totalBill)
        {
            if (Rating >= 3)
                return totalBill * 0.20;
            else
                return totalBill * 0.10;

        }

    } // end class
} // end namespace 
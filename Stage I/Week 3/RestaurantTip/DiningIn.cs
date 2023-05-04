namespace RestaurantApp
{
    class DiningIn : Restaurant
    {

        public DiningIn(string newName, int newRating) : base(newName, newRating)
        { }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalculateTip(double totalBill)
        {
            if (Rating >= 2)
            {
                double tip = totalBill * 0.15;
                return tip;
            }
            else
            {
                double tip = totalBill * 0.05;
                return tip;
            }
        }

    } // end class
} // end namespace
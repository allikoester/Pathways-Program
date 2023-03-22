namespace RestaurantApp
{
    class TakeOut : Restaurant
    {

        public TakeOut(string newName, int newRating) : base(newName, newRating)
        { }

        public override string ToString()
        {
            return base.ToString();
        }

        public override double CalculateTip(double totalBill)
        {
            double tip = totalBill * 0.10;
            return tip;
        }


    } // end class
} // end namespace
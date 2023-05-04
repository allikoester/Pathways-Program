namespace RestaurantApp
{
    class Restaurant
    {
        public string Name { get; set; }

        public int Rating { get; set; }

        public Restaurant()
        {
            Name = " ";
            Rating = 0;
        }

        public Restaurant(string newName, int newRating)
        {
            Name = newName;
            Rating = newRating;
        }

        public override string ToString()
        {
            return "The name of the restaurant is " + Name + ", and the rating is " + Rating;
        }

        public virtual double CalculateTip(double totalBill)
        {
            double tip = totalBill * 0.05;
            return tip;
        }
    } // end class
} // end namespace